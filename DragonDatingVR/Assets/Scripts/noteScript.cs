using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noteScript : MonoBehaviour {
    float speed = -6.0f;
    Vector2 move;
    // Use this for initialization
    void Start () {
        move = new Vector2(0, 0);
    }
	
	// Update is called once per frame
	void Update () {
        move = new Vector2(speed, 0);
        transform.Translate(move * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        //Debug.Log("collided");
        if (col.gameObject.tag == "rhythm")
        {
            Destroy(this.gameObject);
           // rhythm1.currentPower -= 7;
        }

    }
}
