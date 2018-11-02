using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingPowerProduce : MonoBehaviour {

    float basePower;
    int buildingLevel;
    public float totalPower;
    public bool TEST_addLevel;

	// Use this for initialization
	void Start () {
        basePower = 1;
        buildingLevel = 1;
        totalPower = basePower * buildingLevel;
	}
	
	// Update is called once per frame
	void Update () {
        if (TEST_addLevel) {
            UpgradeBuilding();
            TEST_addLevel = false;
        }
	}

    void UpgradeBuilding() {
        buildingLevel++;
        ReCalculateTotalPower();
    }

    void ReCalculateTotalPower() {
        totalPower = basePower * buildingLevel;
    }

}
