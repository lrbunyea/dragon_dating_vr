using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookDespawn : MonoBehaviour {

	// Use this for initialization
	void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Book" || other.gameObject.tag == "StackedBook")
        {
            Destroy(other.gameObject);
        }
    }
}
