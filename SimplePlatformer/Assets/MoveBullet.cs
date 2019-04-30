using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour {
	public bool enemyBullet;
	public float movementSpeed;
	public int bulletDamage=1;
	public Rigidbody2D theRB2D;

	public GameObject soundSpawn;
	// Use this for initialization
	void Start () {
		theRB2D = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		theRB2D.velocity = transform.right*movementSpeed;
	}

	void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
	void OnTriggerEnter2D(Collider2D other)
    {
		if(other.gameObject.tag == "Enemy"  && !enemyBullet)
		{
			
			other.GetComponent<EnemyHealthController>().TakeDamage(bulletDamage);
			Instantiate(soundSpawn, transform.position, transform.rotation);
			Destroy(gameObject);
		}
		else if(other.gameObject.tag == "Player" && enemyBullet )
		{
			//Damage Player
			Destroy(gameObject);
		}
		
    }

}
