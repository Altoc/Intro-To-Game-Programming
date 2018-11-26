using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrGhostBehavior : MonoBehaviour {

    public GameObject pacman;

    private bool isEdible;
    private float isEdibleTimer;

    private Animator animator;

    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();

        isEdible = pacman.GetComponent<ScrPacMan>().GhostEdible;
        isEdibleTimer = pacman.GetComponent<ScrPacMan>().GhostEdibleTimer;
    }
	
	// Update is called once per frame
	void Update () {
        isEdible = pacman.GetComponent<ScrPacMan>().GhostEdible;
        isEdibleTimer = pacman.GetComponent<ScrPacMan>().GhostEdibleTimer;

        if (isEdible == true)
        {
            animator.SetTrigger("IsEdible");
        }
        else if (isEdible == false) {
            animator.SetTrigger("IsNotEdible");
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            if (isEdible == true)
            {
                animator.SetTrigger("Ate");
            }
        }
    }
}
