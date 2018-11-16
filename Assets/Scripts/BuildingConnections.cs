using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingConnections : MonoBehaviour {

    public int maxNumberOfConnections;
    public List<GameObject> connections;
    public Enums.PowerConnectionType connectionType;

    GameManager gm;
    public bool TEST_showConnections;

	// Use this for initialization
	void Start () {
        connections = new List<GameObject>();
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {

        if(connections.Count > 0 && TEST_showConnections)
        {
            foreach (GameObject con in connections)
                Debug.DrawLine(gameObject.transform.position, con.transform.position, Color.red, 10000);
        }
	}

    public bool ConnectionCanBeAdded(Enums.PowerConnectionType otherConnectionType)
    {
        return (connections.Count + 1) <= maxNumberOfConnections && !(otherConnectionType == Enums.PowerConnectionType.output && connectionType == Enums.PowerConnectionType.output);
    }
}
