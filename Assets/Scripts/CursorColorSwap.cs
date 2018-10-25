﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorColorSwap : MonoBehaviour {

    public Material red;
    public Material green;
    GameManager gm;

	// Use this for initialization
	void Start () {
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }
	
	// Update is called once per frame
	void Update () {

    }

    public void SetMaterial() {
        var renderer = GetComponent<Renderer>();
        renderer.material = gm.canBuild ? green : red;
    }
}
