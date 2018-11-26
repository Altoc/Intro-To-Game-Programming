using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door02_behavior : MonoBehaviour {

    public GameObject player;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Player")
        {
            player.transform.position = new Vector3(-13.5f, 0, 0);
        }
    }
}
