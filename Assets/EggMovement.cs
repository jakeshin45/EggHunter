using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggMovement : MonoBehaviour {

    private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = new Vector2(-1.0f, 0);
    }

    // Update is called once per frame
    void Update () {
        if (transform.position.x < -4)
            Destroy(this.gameObject);

        if(GameControl.instance.gameOver == true)
        {
            rb2d.velocity = Vector2.zero;
        }
	}


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (this.gameObject.tag == "RegularEgg")
        {
            GameControl.instance.FrogScored(1);
        }

        if(this.gameObject.tag == "GoldEgg")
        {
            GameControl.instance.FrogScored(2);
        }

        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
