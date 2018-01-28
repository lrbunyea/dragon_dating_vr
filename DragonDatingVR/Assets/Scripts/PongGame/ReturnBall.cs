using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnBall : MonoBehaviour {

    public AudioSource hit;

    void Start ()
    {
       // hit.GetComponent<AudioSource>();
    }

	void OnTriggerStay2D(Collider2D other)
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("There was a click!");
            other.transform.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 1100f));
            hit.Play();
        }
    }
}
