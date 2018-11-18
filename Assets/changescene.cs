using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changescene : MonoBehaviour {


        void FixedUpdate() { Screen.SetResolution(640, 960, true); }
    



    public void changemenu(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
