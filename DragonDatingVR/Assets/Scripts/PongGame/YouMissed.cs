using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouMissed : MonoBehaviour {
    public int numMisses;

    void Start()
    {
        numMisses = 0;
    }

	void OnTriggerEnter2D(Collider2D other)
    {
        if (numMisses == 2)
        {
            Debug.Log("This is finished, boyo");
        }
        Destroy(other.gameObject);
        numMisses++;
    }
}
