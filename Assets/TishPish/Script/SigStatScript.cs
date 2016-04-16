using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


/*
How this script works:
Every time a beacon is placed, it should be added to the list of 
transmitterpositions. this script will then iterate through all transmitters
and find minimum distance from player to all transmitters.
If player crosses the allowedRange, Signal will be lost.
Change HUD position by changing labelx and labely
*/
public class SigStatScript : MonoBehaviour {
	Transform me;
	String text = "this";
	public long allowedRange = 10;
	List<Transform> transmitterPositions = new List<Transform>();
	public int labelx = 0;
	public int labely = 0;
	public long minDist=0;
	// Use this for initialization
	void Start () {
		me = GameObject.FindGameObjectWithTag("Player").transform;
		transmitterPositions.Add(GameObject.FindGameObjectWithTag("lunarModule").transform);
	}
	
	// Update is called once per frame
	void Update () {
		minDist = 1 << 29;
		foreach(Transform i in transmitterPositions) {
			
			long x = (long) Mathf.Sqrt((me.position.x - i.position.x) * (me.position.x - i.position.x) +
				(me.position.y - i.position.y) * (me.position.y - i.position.y) +
				(me.position.z - i.position.z) * (me.position.z - i.position.z));
			minDist = x < minDist ? x : minDist;
		}
		//text.Insert(0,minDist);
		text = minDist > allowedRange ? "Signal Lost" : "Signal Active";
	}

	void OnGUI() {
		GUI.Label(new Rect(0,0,100,20),text);
	}
}
