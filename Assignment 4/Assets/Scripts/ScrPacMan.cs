using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrPacMan : MonoBehaviour {

    public int HP;
    public bool GhostEdible;
    public float GhostEdibleTimer;

    public GameObject ghost1;
    public GameObject ghost2;
    public GameObject ghost3;
    public GameObject ghost4;

    bool moveUp;
    bool moveDown;
    bool moveLeft;
    bool moveRight;

    private Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("up")) //press button
            if (moveUp == false) //allow to move
                moveUp = true;
        if (Input.GetKeyDown("down")) //press button
            if (moveDown == false) //allow to move
                moveDown = true;
        if (Input.GetKeyDown("left")) //press button
            if (moveLeft == false) //allow to move
                moveLeft = true;
        if (Input.GetKeyDown("right")) //press button
            if (moveRight == false) //allow to move
                moveRight = true;

        if (moveUp == true)
        {
            animator.SetTrigger("MoveUp");
            transform.Translate(new Vector3(0f, 0.2f, 0f));   //move
            moveUp = false;
        }
        if (moveDown == true)
        {
            animator.SetTrigger("MoveDown");
            transform.Translate(new Vector3(0f, -0.2f, 0f));   //move
            moveDown = false;
        }
        if (moveLeft == true)
        {
            animator.SetTrigger("MoveLeft");
            transform.Translate(new Vector3(-0.2f, 0f, 0f));   //move
            moveLeft = false;
        }
        if (moveRight == true)
        {
            animator.SetTrigger("MoveRight");
            transform.Translate(new Vector3(0.2f, 0f, 0f));   //move
            moveRight = false;
        }

        if (HP <= 0) {                                          //if dead
            animator.SetTrigger("Died");
        }

        if (GhostEdible == true) {
            GhostEdibleTimer = GhostEdibleTimer - 1 * Time.deltaTime;
            if (GhostEdibleTimer <= 0) {
                GhostEdible = false;
                GhostEdibleTimer = 5;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Ghost")// || (coll.gameObject.name == "Ghost2") || (coll.gameObject.name == "Ghost3") || (coll.gameObject.name == "Ghost4")
        {
            if(GhostEdible == false)
                HP = HP - 1;
        }

        if (coll.gameObject.tag == "PowerUpDot") {
            GhostEdible = true;
        }
    }

}
