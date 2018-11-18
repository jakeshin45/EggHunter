using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Movement_1 : MonoBehaviour {

    private Rigidbody2D rb2d;
    private int RGN;
    // Use this for initialization
    void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = new Vector2(-2f, 0);
    }

    private void RepositionBackground()
    {
        transform.position = (Vector2)transform.position + new Vector2(40, 0);
    }
    // Update is called once per frame
    void Update () {
        if(GameControl.instance.gameOver == true)
        {
            rb2d.velocity = Vector2.zero;
        }

        if (transform.position.x < -4)
            Destroy(this.gameObject);
    }
}
