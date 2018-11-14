﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public bool buildMode;
    public int selectedBuildingIndex;

    public float o2;
    public float temperature;
    public float scrapMetal;

    public GameObject[] buildingArray;

    public bool canBuild;
    public bool connectButtonToggled;

    public GameObject selectedBuilding;

	// Use this for initialization
	void Start () {
        buildMode = false;
        connectButtonToggled = false;
        selectedBuildingIndex = 0;
        o2 = 100;
        temperature = -125.0f;
        scrapMetal = 20;
        canBuild = true;
        //selectedBuilding = buildingArray[selectedBuildingIndex];
    }
	
	// Update is called once per frame
	void Update () {
        if (buildMode)
            connectButtonToggled = false;
	}

    public void SetBuildMode(bool b)
    {
        buildMode = b;

        if (selectedBuilding == null)
            selectedBuilding = buildingArray[selectedBuildingIndex];

        CursorObjectSwap cos = GameObject.FindGameObjectWithTag("Cursor").GetComponent<CursorObjectSwap>();
        if (buildMode)
        {
            cos.instantiatedGos[selectedBuildingIndex].SetActive(true);
        }
        else if (!buildMode)
        {
            cos.SetAllFalse();
            selectedBuilding = null;
        }
    }
}
