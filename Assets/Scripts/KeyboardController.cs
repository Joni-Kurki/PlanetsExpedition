using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class KeyboardController : MonoBehaviour {

    GameManager gm;

	// Use this for initialization
	void Start () {
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            var uimodetextgo = GameObject.FindGameObjectsWithTag("UI").FirstOrDefault(f => f.gameObject.name == "UI_ModeText");
            UIBuildMode ubmscript = uimodetextgo.GetComponent<UIBuildMode>();
            ubmscript.ToggleBuildMode();
        }
        if (Input.GetKeyDown(KeyCode.F2))
        {
            if (gm.selectedBuildingIndex > 0)
            {
                CursorObjectSwap cos = GameObject.FindGameObjectWithTag("Cursor").GetComponent<CursorObjectSwap>();
                cos.SetAllFalse();
                gm.selectedBuildingIndex--;
                var uimodetextgo = GameObject.FindGameObjectsWithTag("UI").FirstOrDefault(f => f.gameObject.name == "UI_ModeText");
                UIBuildMode ubmscript = uimodetextgo.GetComponent<UIBuildMode>();
                ubmscript.SetBuildModeText();
            }
        }
        if (Input.GetKeyDown(KeyCode.F3))
        {
            if (gm.selectedBuildingIndex + 1 < gm.buildingArray.Length)
            {
                CursorObjectSwap cos = GameObject.FindGameObjectWithTag("Cursor").GetComponent<CursorObjectSwap>();
                cos.SetAllFalse();
                gm.selectedBuildingIndex++;
                var uimodetextgo = GameObject.FindGameObjectsWithTag("UI").FirstOrDefault(f => f.gameObject.name == "UI_ModeText");
                UIBuildMode ubmscript = uimodetextgo.GetComponent<UIBuildMode>();
                ubmscript.SetBuildModeText();
            }
        }
        // Building mode
        if (Input.GetMouseButtonDown(0) && gm.buildMode && gm.canBuild){
            BuildingBuilder builder = GameObject.FindGameObjectWithTag("Builder").GetComponent<BuildingBuilder>();
            builder.BuildBuilding(GameObject.FindGameObjectWithTag("Cursor").transform.position);
        } 
        // Selection mode
        else if (Input.GetMouseButtonDown(0) && !gm.buildMode)
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit = new RaycastHit();

            
            if (Physics.Raycast(ray, out hit))
            {
                // If building is hit
                if (hit.collider.gameObject.tag == "Building_hitboxable")
                {
                    GameObject prevGo = null; 
                    // If connecting buildings
                    if(gm.connectButtonToggled && gm.selectedBuilding != null)
                    {
                        prevGo = gm.selectedBuilding;
                    }
                    

                    BuildingScript bs = hit.collider.gameObject.GetComponent<BuildingScript>();
                    bs.Select(hit.collider.gameObject);

                    if(prevGo != null && gm.selectedBuilding != null && prevGo != gm.selectedBuilding)
                    {
                        Debug.Log("Selection happened between "+prevGo.name + " :: "+ gm.selectedBuilding.name);
                        // CHECKKI tänne onko vapaata
                        var cs = prevGo.GetComponent<BuildingConnections>();
                        var cs2 = gm.selectedBuilding.GetComponent<BuildingConnections>();

                        if (cs.ConnectionCanBeAdded(cs2.connectionType) && cs2.ConnectionCanBeAdded(cs.connectionType))
                        {
                            cs.connections.Add(gm.selectedBuilding);

                            //cs2 = gm.selectedBuilding.GetComponent<BuildingConnections>();
                            cs2.connections.Add(prevGo);

                            var cable = Instantiate(gm.powerCablePrefab, prevGo.transform.position, gm.powerCablePrefab.transform.rotation);
                            var cableS = cable.GetComponent<PowerCablePath>();
                            cableS.SetPowerCable(prevGo.transform.position, gm.selectedBuilding.transform.position);

                            gm.connectButtonToggled = false;
                        }
                        else
                        {
                            Debug.Log("Not enough connection slots");
                        }
                    }

                }
            }
        }
	}    
}
