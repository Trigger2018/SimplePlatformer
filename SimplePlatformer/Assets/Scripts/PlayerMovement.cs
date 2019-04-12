using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody2D theRB2d;
	public float movementSpeed;
 void Start()
 {
	 theRB2d = GetComponent<Rigidbody2D>();
 }

void Update()
{
	//MyMovement01();
	MyMovement02();
}


public void MyMovement01()
{
	//works best with no gravity 
	//with gravity has a jetpack feel
	if(Input.GetKeyDown(KeyCode.W))
	{
		theRB2d.velocity += new Vector2(0f, 1.0f )*movementSpeed;

	}
	if(Input.GetKeyDown(KeyCode.S))
	{
		theRB2d.velocity += new Vector2(0.0f, -1.0f )*movementSpeed;

	}
	if(Input.GetKeyDown(KeyCode.A))
	{
		theRB2d.velocity += new Vector2(-1.0f, 0.0f)*movementSpeed;

	}
	if(Input.GetKeyDown(KeyCode.D))
	{
		theRB2d.velocity += new Vector2(1.0f, 0.0f)*movementSpeed;

	}
}

public void MyMovement02()
{
	theRB2d.velocity += new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"))*movementSpeed;
}

}
