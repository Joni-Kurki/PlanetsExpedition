using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITopBanner : MonoBehaviour {

    public Text o2Text;
    public Text tempText;
    public Text resText;
    GameManager gm;

    public float updateInterval;
    private float lastCheck;

	// Use this for initialization
	void Start () {
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();

        lastCheck = 0;
    }
	
	// Update is called once per frame
	void Update () {
		if(Time.time >= (lastCheck + updateInterval))
            UpdateBannerTexts();
	}

    // Updates UITopBanner texts every desired intervals
    void UpdateBannerTexts()
    {
        o2Text.text = gm.o2.ToString();
        tempText.text = gm.temperature.ToString();
        resText.text = gm.scrapMetal.ToString();

        lastCheck = Time.time;
    }
}
