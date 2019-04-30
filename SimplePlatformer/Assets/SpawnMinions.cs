using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMinions : MonoBehaviour {

	public GameObject minion;
	public Transform spawnPoint, spawnPoint1, spawnPoint2;
	public float spanwClock, spanwClock1, spanwClock2;
	private float spCounter, spCounter1, spCounter2;

	// Use this for initialization
	void Start () {
		spCounter=spanwClock;
		spCounter1 = spanwClock1;
		spCounter2 = spanwClock2;
	}
	
	// Update is called once per frame
	void Update () {
		spCounter -= Time.deltaTime;
		spCounter1 -= Time.deltaTime;
		spCounter2 -= Time.deltaTime;

		if(spCounter<=0)
		{
			SpwnGuys(minion, spawnPoint);
			spCounter=spanwClock;
		}
		if(spCounter1<=0)
		{
			SpwnGuys(minion, spawnPoint1);
			spCounter1=spanwClock1;
		}
		if(spCounter2<=0)
		{
			SpwnGuys(minion, spawnPoint2);
			spCounter2=spanwClock2;
		}
	}


	public void SpwnGuys(GameObject itemToSwpan, Transform spawnLoaction)
	{
		Instantiate(itemToSwpan, spawnLoaction.position, spawnLoaction.rotation);
	}
}
