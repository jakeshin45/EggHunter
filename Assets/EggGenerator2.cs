using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggGenerator2 : MonoBehaviour {

    public GameObject Egg1;
    private float RGN;
    private int RGN2;
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
            RGN2 = Random.Range(0, 10);
            if(RGN2 < 3)
                Instantiate(Egg1, this.transform.position, Quaternion.identity);
            RGN = Random.Range(2.5f, 5.0f);
            yield return new WaitForSeconds(RGN);
            MakingEggNow = true;
        }
    }
}
