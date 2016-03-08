using UnityEngine;
using System.Collections;

public class opponent : MonoBehaviour {

    public GameObject ball;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if( ball.transform.position.x > transform.position.x)
        {
            transform.position = new Vector3(transform.position.x + 0.1f, transform.position.y, transform.position.z);
        }

        if (ball.transform.position.x < transform.position.x)
        {
            transform.position = new Vector3(transform.position.x - 0.1f, transform.position.y, transform.position.z);
        }

        if (ball.transform.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x , transform.position.y +0.1f, transform.position.z);
 
        }

        if (ball.transform.position.y < transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y -0.1f, transform.position.z);
        }
    }
}
