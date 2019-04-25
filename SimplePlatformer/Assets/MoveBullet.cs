using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour {

	public float movementSpeed;
	public Rigidbody2D theRB2D;
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
		if(other.gameObject.tag != "Player" )
		{
			Destroy(gameObject);
		}
    }

}
