using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Yarn.Unity;

public class yarnCommands : MonoBehaviour {

    public GameObject ike;
    private GameObject ike2;
    public Canvas theCanvas;
    public GameObject laura;
    private GameObject laura2;
    public GameObject brad;
    private GameObject brad2;

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    [YarnCommand("ikein")]
    public void ikein()
    {
        ike2 = Instantiate(ike);
        ike2.transform.SetParent(theCanvas.transform, false);
    }
    [YarnCommand("ikeout")]
    public void ikeout()
    {
        Destroy(ike2);
    }
    [YarnCommand("laurain")]
    public void laurain()
    {
        laura2 = Instantiate(laura);
        laura2.transform.SetParent(theCanvas.transform, false);
    }
    [YarnCommand("lauraout")]
    public void lauraout()
    {
        Destroy(laura2);
    }
    [YarnCommand("bradin")]
    public void bradin()
    {
        brad2 = Instantiate(brad);
        brad2.transform.SetParent(theCanvas.transform, false);
    }
    [YarnCommand("bradout")]
    public void bradout()
    {
        Destroy(brad2);
    }
}
