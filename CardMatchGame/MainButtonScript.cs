using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainButtonScript : MonoBehaviour
{

    private void OnMouseDown()
    {
        string sceneName = "";

        if (gameObject.name == "Easy")
        {
            GetComponent<AudioSource>().Play();
            sceneName = "GameScene";
        }
        else if (gameObject.name == "Hard")
        {
            GetComponent<AudioSource>().Play();
            sceneName = "GameScene2";
        }
        else if (gameObject.name == "Tutorial")
        {
            GetComponent<AudioSource>().Play();
            sceneName = "TutorialScene";
        }
        else if (gameObject.name == "Info")
        {
            GetComponent<AudioSource>().Play();
            sceneName = "InfoScene";
        }
        else if (gameObject.name == "Remove")
        {
            GetComponent<AudioSource>().Play();
            sceneName = "Main";
        }
        else if (gameObject.name == "Exit_app")
        {
            GetComponent<AudioSource>().Play();
            Application.Quit();
        }


        if (!string.IsNullOrEmpty(sceneName))
        {
            SceneManager.LoadScene(sceneName);
        }
    }

}