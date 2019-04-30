using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackController : MonoBehaviour {

public PathFollowerScript myPath;
	public bool shootAtPlayer;
	public float shotTimer;
	private float shotTimerCounter;
	public GameObject bullet;

	public bool diveBombPlayer;
	public float diveSpeed;
	public GameObject player;
	public Rigidbody2D myRB2D;

	// Use this for initialization
	void Start () {
		shotTimerCounter = shotTimer;
		 myPath = GetComponent<PathFollowerScript>();
		 player = GameObject.FindGameObjectWithTag("Player");
		 myRB2D = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if(diveBombPlayer)
		{
			myPath.enabled = false;
			shootAtPlayer = false;
			Vector3 playerDir = player.transform.position - transform.position;
			myRB2D.velocity  = playerDir*diveSpeed*Time.deltaTime;
		}
		if(shootAtPlayer)
		{
			shotTimerCounter -=Time.deltaTime;
			if(shotTimerCounter<=0)
			{
				Vector3 dir =  (GameObject.FindGameObjectWithTag("Player").transform.position -transform.position);
				float angle =   Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
				Instantiate(bullet, transform.position, Quaternion.AngleAxis(angle, Vector3.forward) );
				shotTimerCounter = shotTimer;
			}
		}
	}
	void OnTriggerEnter2D(Collider2D other)
    {
		if(other.gameObject.tag == "Player" )
		{
			Destroy(other.gameObject);
		}
    }


	
}
