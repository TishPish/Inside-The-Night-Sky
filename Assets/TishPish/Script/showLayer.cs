using UnityEngine;
using System.Collections;

public class showLayer : MonoBehaviour {

	//GameObject player;
	void Start () 
	{
		//player = Camera.main;
	}

	void Update () {

		Vector3 vv = gameObject.transform.position;
		float dis = vv.x- Camera.main.transform.position.x;
		float dis2 = vv.z- Camera.main.transform.position.z;
//		Debug.Log(dis);

		if (Input.GetKeyDown(KeyCode.A)) // not complete :/
		{
			if ((dis<=50 && dis >= -50) && (dis2<750 && dis2>-750))
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
