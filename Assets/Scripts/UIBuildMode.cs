using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBuildMode : MonoBehaviour {

    public Text buildModeText;
    private bool isBuildModeOn = false;

	// Use this for initialization
	void Start () {
        buildModeText.text = "";
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ToggleBuildMode()
    {
        isBuildModeOn = !isBuildModeOn;

        GameManager gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        gm.SetBuildMode(isBuildModeOn);

        SetBuildModeText();
    }

    void SetBuildModeText()
    {
        buildModeText.text = isBuildModeOn ? "BuildMode" : "";
    }
}
