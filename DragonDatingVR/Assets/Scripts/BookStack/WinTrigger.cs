using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinTrigger : MonoBehaviour {

	// Use this for initialization
	void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "StackedBook")
        {
            SceneManager.LoadScene("laura2");
        }
    }
}
