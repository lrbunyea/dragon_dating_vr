using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnBall : MonoBehaviour {

	void OnTriggerStay2D(Collider2D other)
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("There was a click!");
            other.transform.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 1100f));
        }
    }
}
