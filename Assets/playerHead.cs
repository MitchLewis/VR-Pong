using UnityEngine;
using System.Collections;

public class playerHead : MonoBehaviour {
    public GameObject head;
    private Vector3 offset;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //transform.right+= head.transform.right;
        transform.parent = head.transform;
        

       //offset = head.Gaze.direction + head.transform.position;
    }
}
