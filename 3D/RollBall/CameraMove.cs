using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    Transform playerTransForm;
    Vector3 offSet;
    // Start is called before the first frame update
    void Awake()
    {
        playerTransForm = GameObject.FindWithTag("Player").transform;
        offSet = transform.position - playerTransForm.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = playerTransForm.position + offSet;
    }
}
