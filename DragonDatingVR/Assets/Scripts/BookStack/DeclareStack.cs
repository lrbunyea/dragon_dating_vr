using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeclareStack : MonoBehaviour
{

    // Use this for initialization
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Book")
        {
            other.gameObject.tag = "StackedBook";
        }
    }
}
