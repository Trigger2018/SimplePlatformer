using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour {

	public float rotateSpeed;
	public bool allowRotate;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(allowRotate)
		{
			transform.Rotate(Vector3.forward, rotateSpeed*Time.deltaTime, Space.World);
		}
	}
}
