using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorToMouse : MonoBehaviour {

    public float distance;


	// Use this for initialization
	void Start () {
        distance = gameObject.transform.position.z - Camera.main.transform.position.z;
	}
	
	// Update is called once per frame
	void Update () {
        //var pos = Input.mousePosition;
        //pos.z = distance;
        //transform.position = Camera.main.ScreenToWorldPoint(pos);
        //transform.position = new Vector3(transform.position.x, 0.01f, transform.position.z);
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit = new RaycastHit();

        if(Physics.Raycast(ray, out hit))
        {
            transform.position = hit.point;
            transform.position = new Vector3(transform.position.x, 0.01f, transform.position.z);
        }

        //if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100)){
        //    transform.position = Camera.main.ScreenToWorldPoint(hit.point);
        //    transform.position = new Vector3(transform.position.x, 0.01f, transform.position.z);
        //}

    }
}
