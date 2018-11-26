using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bunnyBillboard : MonoBehaviour {

    Transform bunny;
    float yPos;

    public GameObject Zombunny;
    public Renderer rend;

    // Use this for initialization
    void Start () {
        bunny = Zombunny.transform;
        yPos = transform.position.y + 2;
        rend = GetComponent<Renderer>();
    }
	
	// Update is called once per frame
	void Update () {
        //transform.position = bunny.position;
        transform.position = new Vector3(bunny.position.x, yPos, bunny.position.z);
        if (Zombunny.GetComponent<EnemyMovement>().scared == true)
        {
            rend.material.color = Color.blue;
        }
        else {
            rend.material.color = Color.red;
        }
    }
}
