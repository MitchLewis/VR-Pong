using UnityEngine;
using System.Collections;

public class score : MonoBehaviour {

   //public GameObject head;
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


        GetComponent<TextMesh>().text = string.Format("Player: {0} \nOpponet: {1}", ball1.playerScore, ball1.opponentScore);

        //transform.parent = head.transform;
    }
}
