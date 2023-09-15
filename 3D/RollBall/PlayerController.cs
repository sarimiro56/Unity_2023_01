using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float jumpPower;
    Rigidbody rigid;
    bool isJump;
    public int itemCount;
    AudioSource audio;
    public GameController director;
    PlayerController ballText;
    
    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
        isJump = false;
    }
    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        rigid.AddForce(new Vector3(h, 0, v), ForceMode.Impulse);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    rigid.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
        //}
        if (Input.GetButtonDown("Jump") && !isJump)
        {
            isJump = true;
            rigid.AddForce(new Vector3(0, jumpPower, 0), ForceMode.Impulse);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Stage") isJump = false;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Item")
        {
            itemCount++;
            audio.Play();
            other.gameObject.SetActive(false);
        }
        else if (other.tag == "Finish")
        {
            if (itemCount == director.totalCount)  //5는 변수로 대체
            {
                SceneManager.LoadScene(director.stage + 1);
                if (other.tag == "Finish" && SceneManager.GetActiveScene().name == "Scene1")
                {
                    SceneManager.LoadScene(director.stage + 2);
                }
            }
            else
            {
                //SceneManager.LoadScene("Scene0");
                SceneManager.LoadScene(director.stage);
            }
        }

    }
}
