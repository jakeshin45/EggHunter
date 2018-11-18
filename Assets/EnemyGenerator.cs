using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour {

    public GameObject Enemy1;
    public GameObject Enemy2;
    public GameObject Enemy3;
    private int RGN;
    private float RGN2;
    private bool MakingEggNow = true;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameControl.instance.gameOver == false)
        {
            StartCoroutine(generatEGG());
        }
    }

    private IEnumerator generatEGG()
    {
        if (MakingEggNow == true)
        {
            MakingEggNow = false;
            RGN = Random.Range(0, 10);
            Debug.Log(RGN);
            if (RGN < 3)
                Instantiate(Enemy1, this.transform.position, Quaternion.identity);
            else if (RGN >= 3 && RGN < 7)
                Instantiate(Enemy2, this.transform.position, Quaternion.identity);
            else
                Instantiate(Enemy3, this.transform.position, Quaternion.identity);

            RGN2 = Random.Range(1.5f, 4.0f);
            yield return new WaitForSeconds(RGN2);
            MakingEggNow = true;
        }
    }
}
