using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBehavior : MonoBehaviour {

    public GameObject zombunny;
    public GameObject hellafant;
    public GameObject zombear;
    public GameObject healthKit;
    public GameObject powerUp;

    public float spawnTime;

    private int spawnObjectSelector;
    private GameObject spawnObject;
    private Vector3 location;
    private float spawnTimer;

    // Use this for initialization
    void Start () {
        spawnTimer = spawnTime;
    }
	
	// Update is called once per frame
	void Update () {

        spawnObjectSelector = Random.Range(0, 4);

        switch (spawnObjectSelector) {
            case 0: spawnObject = zombunny; break;
            case 1: spawnObject = hellafant; break;
            case 2: spawnObject = zombear; break;
            case 3: spawnObject = healthKit; break;
            case 4: spawnObject = powerUp; break;
        }

        spawnTimer -= 1 * Time.deltaTime;
        if (spawnTimer <= 0)
        {
            Instantiate(spawnObject, location, Quaternion.identity);
            locationChange();
            spawnTimer = spawnTime;
        }
    }

    void locationChange()
    {
        location = new Vector3(Random.Range(-15.0f, 15.0f), 0, Random.Range(-15.0f, 15.0f));
    }
}
