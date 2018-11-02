using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingPowerRequire : MonoBehaviour {

    public float requiredPower;
    public float equipmentPowerCost;
    public float peoplePowerCost;

	// Use this for initialization
	void Start () {
        requiredPower = (equipmentPowerCost * 1) + (peoplePowerCost * 2);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void UpdatePowerRequirements() {

    }

}
