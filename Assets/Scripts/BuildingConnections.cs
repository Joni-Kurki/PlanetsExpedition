using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingConnections : MonoBehaviour {

    public int maxNumberOfConnections;
    public List<GameObject> connections;

    GameManager gm;
    public bool TEST_showConnections;

	// Use this for initialization
	void Start () {
        connections = new List<GameObject>();
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {
        //if (Input.GetMouseButtonDown(0) && gm.connectButtonToggled && gm.selectedBuilding != null) {
        //    Debug.Log("Connected");
        //    if(transform.gameObject != gm.selectedBuilding)
        //        connections.Add(gm.selectedBuilding);
        //}
        if(connections.Count > 0 && TEST_showConnections)
        {
            foreach (GameObject con in connections)
                Debug.DrawLine(gameObject.transform.position, con.transform.position, Color.red, 10000);
        }
	}
}
