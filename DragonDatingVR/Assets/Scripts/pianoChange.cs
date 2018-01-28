using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pianoChange : MonoBehaviour {

    public Sprite normie;
    public SpriteRenderer thisSprite;
    public Sprite down1;
    public Sprite down2;
    public Sprite down3;
    public Sprite down4;
    private string recentKey;

    // Use this for initialization
    void Start () {
        recentKey = "0";
    }
	
	// Update is called once per frame
	void Update () {
        if ((Input.GetKeyDown("1")))
        {
            recentKey = "1";
            thisSprite.sprite = down1;
        }
        else if ((Input.GetKeyDown("2")))
        {
            recentKey = "2";
            thisSprite.sprite = down2;
        }
        else if ((Input.GetKeyDown("3")))
        {
            recentKey = "3";
            thisSprite.sprite = down3;
        }
        else if ((Input.GetKeyDown("4")))
        {
            recentKey = "4";
            thisSprite.sprite = down4;
        }
        else if (Input.GetKeyUp(recentKey))
        {
             thisSprite.sprite = normie;
        }

    }
}
