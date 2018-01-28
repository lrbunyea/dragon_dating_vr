using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            SceneManager.LoadScene("brad2");
        }
        Destroy(other.gameObject);
        numMisses++;
    }
}
