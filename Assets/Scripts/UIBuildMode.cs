using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBuildMode : MonoBehaviour {

    GameManager gm;
    public Text buildModeText;
    private bool isBuildModeOn = false;

	// Use this for initialization
	void Start () {
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        buildModeText.text = "";
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ToggleBuildMode()
    {
        isBuildModeOn = !isBuildModeOn;
        gm.SetBuildMode(isBuildModeOn);

        SetBuildModeText();
    }

    public void SetBuildModeText()
    {
        buildModeText.text = isBuildModeOn ? "BuildMode "+gm.selectedBuildingIndex : "";
    }

}
