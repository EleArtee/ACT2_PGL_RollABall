using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger2 : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (score.scoreCount == 4)
        {
            SceneManager.LoadScene("GameOver");
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Minigame");
        }

    }
}
