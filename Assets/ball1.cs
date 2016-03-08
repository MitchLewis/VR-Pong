using UnityEngine;
using System.Collections;

public class ball1 : MonoBehaviour {

	public Vector3 initialImpulse;

	// Use this for initialization
	void Start () {

		GetComponent<Rigidbody> ().AddForce (initialImpulse, ForceMode.Impulse);
	
	}

    public static int playerScore = 0;
    public static int opponentScore = 0;
	
	// Update is called once per frame
	void Update () {

        if (transform.position.z > 19f)
        {
            playerScore++;
            transform.position = new Vector3(-2.83f, 2.5f, -7.62f);

        }

        if (transform.position.z < -19f)
        {
            opponentScore++;
            transform.position = new Vector3(-2.83f, 2.57f, -7.62f);
        }
	
	}
}
