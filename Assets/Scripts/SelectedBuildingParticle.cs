using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedBuildingParticle : MonoBehaviour {

    GameManager gm;

	// Use this for initialization
	void Start () {
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }
	
	// Update is called once per frame
	void Update () {
		if(gm.selectedBuilding != null)
        {
            transform.position = gm.selectedBuilding.transform.position;
        }
	}
}
