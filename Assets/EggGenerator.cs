using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggGenerator : MonoBehaviour {

    public GameObject Egg1;
    public GameObject Egg2;
    private int RGN;
    private float RGN2;
    private bool MakingEggNow = true;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update()
    {
        if(GameControl.instance.gameOver == false)
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
            if (RGN < 5)
                Instantiate(Egg1, this.transform.position, Quaternion.identity);
            else
                Instantiate(Egg2, this.transform.position, Quaternion.identity);

            RGN2 = Random.Range(1.6f, 4.0f);
            yield return new WaitForSeconds(RGN2);
            MakingEggNow = true;
        }
    }
}
