using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (score.scoreCount == 8) { 
            SceneManager.LoadScene("Level 2");
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Minigame");
        }

    }
}
