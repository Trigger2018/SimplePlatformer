using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpCollectable : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "Player")
		{
			other.GetComponent<UFOController>().IncreaseSpeed();
			//Play Sound
			//Add to player score or powerup
			Destroy(gameObject);
		}
	}
}
