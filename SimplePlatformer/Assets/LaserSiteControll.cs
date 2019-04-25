using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserSiteControll : MonoBehaviour {

	public LineRenderer myLine;
	public Vector3 startPoint;
	public Vector3 stopPoint;
	private Vector3[] linePoints;
	public bool laserOn;
	// Use this for initialization
	void Start () {
		myLine = GetComponent<LineRenderer>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(laserOn)
		{
			//myLine.enabled = true;
			//linePoints[0] = startPoint;
			//linePoints[1] = stopPoint;
			//myLine.SetPositions(linePoints);
			myLine.SetPosition(0,transform.position );
			myLine.SetPosition(1,stopPoint);
		}
	}

	public void SetStart(Vector3 stpoint)
	{
		startPoint = stpoint;
		//linePoints[0] = startPoint;
	}

	public void SetEnd(Vector3 endpoint)
	{
		stopPoint = endpoint;
		//linePoints[1] = stopPoint;
	}

	public void ToggleLaser()
	{
		laserOn = !laserOn;
		myLine.enabled = laserOn;
	}
}
