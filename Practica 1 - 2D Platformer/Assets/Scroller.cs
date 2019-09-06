using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroller : MonoBehaviour {
	
	public GameObject platillo;
	int index = 0;
	public int MAX_X;
	float dir = 0.3f;
	float last_pos_x;
	float new_pos_x;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		movement();
	}
	
	public void movement()
	{
		index++;
		
		last_pos_x = platillo.transform.position.x;
		new_pos_x = last_pos_x+dir;
		platillo.transform.position = new Vector3(new_pos_x,platillo.transform.position.y,platillo.transform.position.z);
		if(index==MAX_X)
		{
			index = 0;
			if(dir == 0.3f)
				dir = -0.3f;
			else
				dir = 0.3f;
		}
		
		
		
	}
}
