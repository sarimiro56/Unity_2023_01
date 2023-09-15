using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreButtonScript2 : MonoBehaviour
{
    private void OnMouseDown()
    {
        string sceneName = "";

        if (gameObject.name == "Restart_2")
        {
            GetComponent<AudioSource>().Play();
            sceneName = "GameScene2";
        }
        else if (gameObject.name == "Home")
        {
            GetComponent<AudioSource>().Play();
            sceneName = "Main";
        }
        else if (gameObject.name == "Quit")
        {
            GetComponent<AudioSource>().Play();
            Application.Quit(); // 게임 앱 종료. 빌드된 앱에서만 확인해볼 수 있음.
        }

        if (!string.IsNullOrEmpty(sceneName))
        {
            SceneManager.LoadScene(sceneName);
        }
    }
    
}
