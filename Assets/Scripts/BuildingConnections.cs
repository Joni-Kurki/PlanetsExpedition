using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingConnections : MonoBehaviour {

    public int maxNumberOfConnections;
    public List<GameObject> connections;

    GameManager gm;

	// Use this for initialization
	void Start () {
        connections = new List<GameObject>();
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0) && gm.connectButtonToggled && gm.selectedBuilding != null) {
            Debug.Log("May the connecting happen");
        }
	}
}
