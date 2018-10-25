using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingBuilder : MonoBehaviour {

    GameManager gm;

	// Use this for initialization
	void Start () {
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void BuildBuilding(Vector3 position)
    {
        var go = Instantiate(gm.buildingArray[gm.selectedBuildingIndex], position, gm.buildingArray[gm.selectedBuildingIndex].transform.rotation, transform);
        go.SetActive(true);
    }
}
