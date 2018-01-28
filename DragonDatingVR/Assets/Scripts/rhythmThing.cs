using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class rhythmThing : MonoBehaviour {

    public string whatKey;
    private bool isCollided;
    Collider2D otherObj;
    public Slider healthSlider;
    public static int currentPower;
    private float rhythmTimer;

    // Use this for initialization
    void Start () {
        isCollided = false;
        currentPower = 10;
        healthSlider.value = currentPower;
        
    }
	
	// Update is called once per frame
	void Update () {
        rhythmTimer += Time.deltaTime;
        if ((Input.GetKeyDown(whatKey)))
        {
            // thisSprite.sprite = theSprite2;
            //Debug.Log("done the do");
            if (isCollided)
            {
                Debug.Log(rhythmTimer);
                Destroy(otherObj.gameObject);
                if (currentPower < 97)
                {
                    currentPower += 3;
                }
            }
            else
            {
                currentPower -= 3;
            }
        }
        if ((Input.GetKeyUp(whatKey)))
        {
            //Debug.Log("rhythm registered!");
          //  thisSprite.sprite = theSprite1;
            if (isCollided)
            {
                Debug.Log("rhythm registered!");
                Destroy(otherObj.gameObject);
                if (currentPower < 97)
                {
                    currentPower += 3;
                }
            }

        }
        healthSlider.value = currentPower;
        if (healthSlider.value <= 0)
       {
            SceneManager.LoadScene("rhythmScene");
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        // if (coll.gameObject.tag == "rhythm")
        // {
        otherObj = col;
        isCollided = true;

        // }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        isCollided = false;

    }
}
