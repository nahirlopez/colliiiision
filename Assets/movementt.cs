using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementt : MonoBehaviour
{
    public float movespeed;
    public float rotpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, movespeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -movespeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, rotpeed, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -rotpeed, 0);
        }
    }
}
