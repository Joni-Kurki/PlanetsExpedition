using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerCablePath : MonoBehaviour {

    GameManager gm;

	// Use this for initialization
	void Start () {
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }
	
	// Update is called once per frame
	void Update () {

    }

    public void SetPowerCable(Vector3 start, Vector3 end)
    {
        var hCorrection = transform.localScale.y / 2;

        var dir = new Vector3(end.x, hCorrection, end.z) - new Vector3(start.x, hCorrection, start.z);
        var mid = (dir) / 2.0f + new Vector3(start.x, 0, start.z);
        transform.position = mid;
        transform.rotation = Quaternion.FromToRotation(Vector3.up, dir);
        Vector3 scale = transform.localScale;
        scale.y = dir.magnitude;
        transform.localScale = scale;
    }
}
