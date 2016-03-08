using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {

	public float speed = 20f;
    

	
	// Update is called once per frame
	void Update () {

        float inputSpeedVertical = Input.GetAxisRaw ("player");
        float inputSpeedHorizontal = Input.GetAxisRaw ("playerHorizontal");



        transform.position += (new Vector3 (inputSpeedHorizontal *speed * Time.deltaTime , inputSpeedVertical * speed * Time.deltaTime, 0f));

        
        


    }
}
