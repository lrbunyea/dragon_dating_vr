using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateBall : MonoBehaviour {

    public Transform ball;
    private Transform newThing;
    int count = 0;
    GameObject obj;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (count == 100)
        {
            count = 0;
            newThing = Instantiate(ball, new Vector3(Random.Range(-7, 7), 5.5f), Quaternion.identity);
            newThing.GetComponent<Rigidbody2D>().velocity.Set(.1f, 0f);
        }
        count++;
	}
}
