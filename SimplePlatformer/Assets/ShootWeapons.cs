using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootWeapons : MonoBehaviour {


	public GameObject barrel;
	public LaserSiteControll lzrSight;
	public float speed;
	public float angle;



	public UFOController myUFO;
	public GameObject projectile;

	// Use this for initialization
	void Start () {
		myUFO = GetComponent<UFOController>();
	}
	
	// Update is called once per frame
	void Update () {
		ShootProjectile();
	}

	public void ShootProjectile()
	{
		//Vector3 target = new Vector3(0f,0f,0f);
		//target=camera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, camera.nearClipPlane));
		/* Vector3 cursorPosition = Input.mousePosition;
            cursorPosition.z = 2.0f;       // we want 2m away from the camera position
            this.transform.position = Camera.main.ScreenToWorldPoint(cursorPosition); */
Debug.Log("object location " +Camera.main.WorldToScreenPoint(transform.position));
Debug.Log("Mouse location "+Input.mousePosition );
		Vector3 dir =  Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
		//Vector3 dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
		angle =   Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
		barrel.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
		dir.z =0f;
		lzrSight.SetEnd(dir);
		Debug.Log("the mouse coords:" + dir.ToString());
		Debug.Log("stop point: "+lzrSight.stopPoint);
		if(Input.GetMouseButtonDown(1))
		{
			
			lzrSight.ToggleLaser();
		}


		if(Input.GetMouseButtonDown(0))
		{
			dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
			angle =   Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
			
			barrel.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
			Instantiate(projectile, transform.position, barrel.transform.rotation );
		}
	}



		
	

}
