using UnityEngine;
using System.Collections;

public class rightMap : MonoBehaviour {

	public GameObject player;
	public GameObject prefab;
	int []arr3;
	int []arr2;
	int []arr6;
	void Start () 
	{
		arr3 = new int[100];
		arr2 = new int[100];
		arr6 = new int[100];
		for (int i=0;i<100;i++) 
		{
			arr3 [i] = 0;
			arr2 [i] = 0;
			arr6 [i] = 0;
		}
		arr3 [0] = 1;
	}

	void Update () 
	{
		int x = (int)player.transform.position.x;
		int z = (int)player.transform.position.z;
		
		Debug.Log("pos x: "+ x+" posy: "+z);
		if (x > 0 && z > 0) 
		{
			int curX = x % 750;
			int curZ = z % 750;

			if ( curX>375 && curZ>375)
			{
				int gridX = (int) x/1500;
				int gridZ = (int) z/1500;
				Debug.Log("reg 3 "+ gridX);

				if (arr3[gridX+1] ==0)
				{
					Vector3 pos = new Vector3 (1500*(gridX+1), -9.52f, 1500*(gridZ+1));
					Instantiate (prefab, pos, Quaternion.identity);	

					arr3[gridX+1] =1;
				}

			}
			else if ( curX>375 && curZ<375)
			{
				int gridX = (int) x/1500;
				int gridZ = (int) z/1500;
				Debug.Log("reg 3 "+ gridX);
				
				if (arr6[gridX+1] ==0)
				{
					Vector3 pos = new Vector3 (1500*(gridX+1), -9.52f, 1500*gridZ);
					Instantiate (prefab, pos, Quaternion.identity);	
					
					arr6[gridX+1] =1;
				}
			}

			else if ( curX<375 && curZ>375)
			{
				Debug.Log("reg 2");
			}

		}
		else if (x > 0 && z < 0) 
		{
			int curX = x % 750;
			z= z*-1;
			int curZ = z % 750;
			
			if ( curX>375 && curZ>375)
			{
				Debug.Log("reg 9");
			}
			else if ( curX>375 && curZ<375)
			{
				Debug.Log("reg 6");
			}
			
			else if ( curX<375 && curZ>375)
			{
				Debug.Log("reg 8");
			}
			
		}
		else if (x < 0 && z > 0) 
		{
			x= x*-1;
			int curX = x % 750;
			int curZ = z % 750;
			
			if ( curX>375 && curZ>375)
			{
				Debug.Log("pos x: "+ curX+" posy: "+curZ+" need to int. both in 2th quad");
			}
			else if ( curX>375 && curZ<375)
			{
				Debug.Log("pos x: "+ curX+" posy: "+curZ+" need to int.left");
			}
			
			else if ( curX<375 && curZ>375)
			{
				Debug.Log("pos x: "+ curX+" posy: "+curZ+" need to int. top");
			}
			
		}

		else if (x < 0 && z < 0) 
		{
			x= x*-1;
			z = z*-1;
			int curX = x % 750;
			int curZ = z % 750;
			
			if ( curX>375 && curZ>375)
			{
				Debug.Log("pos x: "+ curX+" posy: "+curZ+" need to int. both in 3rd quad");
			}
			else if ( curX>375 && curZ<375)
			{
				Debug.Log("pos x: "+ curX+" posy: "+curZ+" need to int. left in 3rd quad");
			}
			
			else if ( curX<375 && curZ>375)
			{
				Debug.Log("pos x: "+ curX+" posy: "+curZ+" need to int. bottom in 3rd quad");
			}
			
		}

		



	}
/*	void rightSide()
	{
		int z1 = (int) (player.transform.position.x+100)/1500;
		float dis1 = 1500+z1*1500 - player.transform.position.x;

		
		if (right[z1]==0 && dis1 <1550) 
		{
			Vector3 pos = new Vector3 (1500*z1, -9.52f, 0);
			Instantiate (prefab, pos, Quaternion.identity);
			//done =true;
			Debug.Log("instantiated");
			right[z1]=1;
		}
	}*/
}
