using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    public int totalCount;
    public int stage;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
            //SceneManager.LoadScene("Scene"+stage);
            SceneManager.LoadScene(stage);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
