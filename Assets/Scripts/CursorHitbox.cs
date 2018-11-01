using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorHitbox : MonoBehaviour {

    GameManager gm;

	// Use this for initialization
	void Start () {
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Building_hitboxable")
        {
            SetCursor(false);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        OnTriggerEnter(other);
    }

    void OnTriggerExit(Collider other)
    {
        if (other.transform.tag == "Building_hitboxable")
        {
            SetCursor(true);
        }
    }

    private void SetCursor(bool b)
    {
        gm.canBuild = b;
        CursorColorSwap ccs = gameObject.GetComponent<CursorColorSwap>();
        ccs.SetMaterial();
    }
}
