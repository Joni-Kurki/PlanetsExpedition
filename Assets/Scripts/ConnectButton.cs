using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConnectButton : MonoBehaviour {

    public Button btn;
    GameManager gm;

	// Use this for initialization
	void Start () {
        btn = transform.gameObject.GetComponent<Button>();
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {
        if (gm.selectedBuilding == null)
            btn.interactable = false;
        else if(gm.selectedBuilding != null && !gm.buildMode)
            btn.interactable = true;
	}
}
