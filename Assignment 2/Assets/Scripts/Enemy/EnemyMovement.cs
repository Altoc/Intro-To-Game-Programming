using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{
    Transform player;
    //Transform cube;
    public bool scared;
    Vector3 awayFromPlayer;
    //PlayerHealth playerHealth;
    //EnemyHealth enemyHealth;
    UnityEngine.AI.NavMeshAgent nav;

    void Awake ()
    {
        player = GameObject.FindGameObjectWithTag ("Player").transform;
        awayFromPlayer = new Vector3(0, 0, 0);
        //cube = GameObject.FindGameObjectWithTag("Cube").transform;
        //playerHealth = player.GetComponent <PlayerHealth> ();
        //enemyHealth = GetComponent <EnemyHealth> ();
        nav = GetComponent <UnityEngine.AI.NavMeshAgent> ();
        scared = false;
    }


    void Update ()
    {
        if (Input.GetKeyDown("space"))
        {
            if (scared == false)
            {
                scared = true;
            }
            else {
                scared = false;
            }
        }

        if (scared == false){
            nav.SetDestination(player.position);
        }
        if (scared == true){
            nav.SetDestination(awayFromPlayer);
        }
    }
}