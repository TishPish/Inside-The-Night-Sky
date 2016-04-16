using UnityEngine;
using System.Collections;

public class grid1 : MonoBehaviour {

	public int x1,x2,x3,x4;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float dis = Camera.main.transform.position.x;
		float dis2 = Camera.main.transform.position.z;
		//		Debug.Log(dis);
		
		if (Input.GetKeyDown(KeyCode.A)) // not complete :/
		{
			if ((dis<=x2 && dis >= x1) && (dis2<x4 && dis2>=x3))
			{
				Transform[] ts = GetComponentsInChildren<Transform>(true);
				foreach(Transform t in ts)
				{
					t.gameObject.layer = LayerMask.NameToLayer("mapcansee");
				}
			}
		}
	
	}
}
