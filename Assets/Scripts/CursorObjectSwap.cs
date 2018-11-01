using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorObjectSwap : MonoBehaviour {

    public GameObject[] goArray;
    public List<GameObject> instantiatedGos;
    GameManager gm;

	// Use this for initialization
	void Start () {
        instantiatedGos = new List<GameObject>();
        

        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        goArray = gm.buildingArray;

        InstantiateGoArray();
    }
	
	// Update is called once per frame
	void Update () {
        if (gm.buildMode)
        {
            //instantiatedGos[gm.selectedBuildingIndex].SetActive(true);
            //gm.selectedBuilding = instantiatedGos[gm.selectedBuildingIndex];
            if (!instantiatedGos[gm.selectedBuildingIndex].activeSelf)
            {
                instantiatedGos[gm.selectedBuildingIndex].SetActive(true);
            }
            instantiatedGos[gm.selectedBuildingIndex].transform.position = gameObject.transform.position;
        }
    }

    private void InstantiateGoArray()
    {
        foreach(GameObject go in goArray)
        {
            var g = (Instantiate(go, gameObject.transform));
            g.tag = "Cursor_building";
            go.SetActive(false);
            instantiatedGos.Add(g);
        }
    }

    public void SetAllFalse()
    {
        foreach (GameObject go in instantiatedGos)
        {
            go.SetActive(false);
        }
    }
}
