using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOController : MonoBehaviour {

	//Add Variables here
	public Rigidbody2D theRB2D;
	public float movmentSpeed;
	public float energy;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
  
		//Add Movement Code Here
		if(Input.GetKeyDown(KeyCode.W))
		{
			theRB2D.velocity += new Vector2(0f, 1.0f)*movmentSpeed;
		}
		if(Input.GetKeyDown(KeyCode.S))
		{
			theRB2D.velocity += new Vector2(0f, -1.0f)*movmentSpeed;
		}
		if(Input.GetKeyDown(KeyCode.A))
		{
			theRB2D.velocity += new Vector2(-1.0f, 0.0f)*movmentSpeed;
		}
		if(Input.GetKeyDown(KeyCode.D))
		{
			theRB2D.velocity += new Vector2(1.0f, 0f)*movmentSpeed;
		}
		if(Input.GetKeyDown(KeyCode.Space))
		{
			energy = energy - 10;
			theRB2D.velocity = new Vector2(0.0f, 0f)*movmentSpeed;
		}
		

		//theRB2D.velocity = new Vector2( Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"))*movmentSpeed;


	}

	public void IncreaseSpeed()
	{
		movmentSpeed++;
	}
	public void DecreaseSpeed()
	{
		movmentSpeed--;
	}
	public void IncreaseEnergy()
	{
		energy++;
	}
	public void DecreaseEnergy()
	{
		energy--;
	}
}
