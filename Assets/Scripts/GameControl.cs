using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour {

    public static GameControl instance;
    public GameObject gameOverText;
    public GameObject gameOverText2;
    public bool gameOver = false;
    public float scrollSpeed = -1.5f;
    public float EggSpeed = -0.5f;
    public Text scoreText;
    private int score;


    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }

        else if(instance != this)
        {
            Destroy(gameObject);
        }
    }

	// Update is called once per frame
	void Update () {
		if(gameOver == true && Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
	}

    public void FrogScored(int a)
    {
        if(gameOver)
        {
            return;
        }
        score = score + a;
        scoreText.text = "Score: " + score.ToString();

    }

    public void PlayerDied()
    {
        gameOverText.SetActive(true);
        gameOverText2.SetActive(true);
        gameOver = true;
    }
}
