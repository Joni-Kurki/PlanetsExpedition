using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerRouteConnections : MonoBehaviour {

    GameManager gm;

	// Use this for initialization
	void Start () {
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void CalculateRoutes()
    {
        var startGoConnections = gm.selectedBuilding.GetComponent<BuildingConnections>().connections;
        List<GameObject> foundEndPoints = new List<GameObject>();

        foreach(GameObject con in startGoConnections)
        {
            var endPoint = GetConnectionEndPoint(con);
            if (endPoint != null)
                foundEndPoints.AddRange(endPoint);
        }

        Debug.Log(foundEndPoints.Count);
    }

    List<GameObject> GetConnectionEndPoint(GameObject con)
    {
        if (con.GetComponent<BuildingConnections>().connectionType == Enums.PowerConnectionType.inputEndPoint)
            return null;

        List<GameObject> gos = new List<GameObject>();

        foreach(GameObject go in con.GetComponent<BuildingConnections>().connections)
        {
            if(go != con)
            {
                var returnedGO = GetConnectionEndPoint(go);

                if (returnedGO != null)
                {
                    foreach (GameObject g in returnedGO)
                    {
                        if (returnedGO != null && g.GetComponent<BuildingConnections>().connectionType == Enums.PowerConnectionType.inputEndPoint)
                            gos.Add(go);
                    }
                }
            }
        }

        return gos;
    }
    
}
