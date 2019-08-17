using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Its time to bounce some balls");
    }

    // Update is called once per frame
    void Update()
    {
       
    }
	
	void OnCollisionEnter(Collision collision)
	{
		
		Debug.Log("Colison detectada con" + collision.gameObject.name);	
		
	}
}
