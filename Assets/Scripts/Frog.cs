using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frog : MonoBehaviour
{

    private AudioSource eating;
    public AudioClip eatsound;
    private bool isDead = false;
    private bool isMoving = false;
    private Rigidbody2D rb2d;
    private Animator anim;


    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        eating = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead == false && isMoving == false)
        {
            if (Input.GetKeyDown("space") && GameControl.instance.gameOver == false)
            {
                isMoving = true;
                rb2d.velocity = Vector2.zero;
                rb2d.AddForce(new Vector2(0, 300f));
                anim.SetTrigger("Flap");
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            isMoving = false;
        }

        /*
         if(collision.gameObject.tag == "EnemySide")
         {
            rb2d.velocity = Vector2.zero;
            isDead = true;
            anim.SetTrigger("Die");
            GameControl.instance.PlayerDied();
         }
         */

        if (collision.gameObject.tag == "RegularEgg")
        {
            eating.PlayOneShot(eatsound);
        }

        if (collision.gameObject.tag == "GoldEgg")
        {
            eating.PlayOneShot(eatsound);
        }

        if(collision.gameObject.tag == "ForGameOver")
        {
            anim.SetTrigger("Die");
            GameControl.instance.PlayerDied();
        }

        if(collision.gameObject.tag == "ForJump" && GameControl.instance.gameOver == false)
        {
            rb2d.velocity = Vector2.zero;
            if(GameControl.instance.gameOver == false)
                rb2d.AddForce(new Vector2(0, 400));
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "RegularEgg")
        {
            eating.PlayOneShot(eatsound);
        }

        if (collision.gameObject.tag == "GoldEgg")
        {
            eating.PlayOneShot(eatsound);
        }
        /*
        if (collision.gameObject.name == "Enemy_1" || collision.gameObject.name == "Enemy_2" || collision.gameObject.name == "Enemy_3")
        {
            GameControl.instance.PlayerDied();
        }
        */
    }
}
