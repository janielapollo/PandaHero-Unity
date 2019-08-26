using UnityEngine;
using System.Collections;

public class Warp2D : MonoBehaviour {
	

	// Update is called once per frame
	void FixedUpdate () {
		//If Player's Position is Below than -3.81f than
		if(transform.position.x<= -3.75f)
			{
			//Our new Player Position Will - X(3.81f, Current Y, Current X)
			transform.position = new Vector3(3.75f, transform.position.y,transform.position.z);
	
			}
		else if(transform.position.x >= 3.75)
		{
			transform.position = new Vector3(-3.75f, transform.position.y,transform.position.z);
						}
}
}