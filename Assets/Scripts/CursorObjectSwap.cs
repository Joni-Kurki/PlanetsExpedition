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
        InstantiateGoArray();

        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }
	
	// Update is called once per frame
	void Update () {
        //if (gm.buildMode)
        //{
        //    instantiatedGos[gm.selectedBuildingIndex].SetActive(true);
        //    instantiatedGos[gm.selectedBuildingIndex].transform.position = gameObject.transform.position;
        //}
        //else
        //{
        //    instantiatedGos[gm.selectedBuildingIndex].SetActive(false);
        //}
	}

    private void InstantiateGoArray()
    {
        foreach(GameObject go in goArray)
        {
            var g = (Instantiate(go));
            go.SetActive(false);
            instantiatedGos.Add(g);
        }
    }
}
