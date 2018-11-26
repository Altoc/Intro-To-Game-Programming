using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMasterBehavior : MonoBehaviour {
    
    public GameObject spawner;

    private Vector3 location;

    // Use this for initialization
    void Start () {
        location = new Vector3(0, 0, 0);
        Instantiate(spawner, location, Quaternion.identity);
    }
	
	// Update is called once per frame
	void Update () {

	}
}
