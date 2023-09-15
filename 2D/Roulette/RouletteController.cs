using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    // Start is called before the first frame update
    float rotSpeed = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 20;
        }

        transform.Rotate(0, 0, this.rotSpeed);

        this.rotSpeed *= 0.99f;
    }
}
