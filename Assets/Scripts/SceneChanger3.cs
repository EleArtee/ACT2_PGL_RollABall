using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger3 : MonoBehaviour
{

    // Update is called once per frame
    void Update() { 

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Minigame");
        }

    }
}

