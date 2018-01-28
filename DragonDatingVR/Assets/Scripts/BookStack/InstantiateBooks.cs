using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateBooks : MonoBehaviour {

    public Transform book;
    private Transform newThing;
    float timeLeft = 2f;
    GameObject obj;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            newThing = Instantiate(book, new Vector3(Random.Range(-7, 7), 5.5f), Quaternion.identity);
            newThing.GetComponent<Rigidbody2D>().velocity.Set(0f, -.5f);
            timeLeft = 2f;
        }
	}
}
