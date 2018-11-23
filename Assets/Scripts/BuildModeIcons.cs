using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildModeIcons : MonoBehaviour {

    Image buildModeIcon;
    GameManager gm;
    public Sprite[] icons;

	// Use this for initialization
	void Start () {
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {
        if (gm.buildMode)
            gameObject.GetComponent<Image>().sprite = icons[0];
        else
            gameObject.GetComponent<Image>().sprite = icons[1];
    }
}
