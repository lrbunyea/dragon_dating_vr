using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateBooks : MonoBehaviour {

    public Transform book;
    private Transform newThing;
    int count = 0;
    GameObject obj;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (count == 120)
        {
            count = 0;
            newThing = Instantiate(book, new Vector3(Random.Range(-7, 7), 5.5f), Quaternion.identity);
            newThing.GetComponent<Rigidbody2D>().velocity.Set(0f, -.5f);
        }
        count++;
	}
}
