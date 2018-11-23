using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClickController : MonoBehaviour {

    GameManager gm;
    PowerRouteConnections prs;

    // Use this for initialization
    void Start() {
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        prs = GameObject.FindGameObjectWithTag("PowerRouteManager").GetComponent<PowerRouteConnections>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ConnectButtonClicked() {
        gm.connectButtonToggled = true;
    }

    public void RoutesButtonClicked()
    {
        prs.CalculateRoutes();
    }

    public void DeleteButtonClicked()
    {
        gm.selectedBuilding.GetComponent<BuildingConnections>().RemoveConnections();
    }
}
