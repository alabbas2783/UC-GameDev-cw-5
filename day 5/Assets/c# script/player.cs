using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    public Transform minpos;
    public Transform maxpos;
    Rigidbody rb;
    int inc = 3;
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>();  
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }
     void move()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
   
            transform.position = new Vector3(Mathf.Clamp(transform.position.x + inc, maxpos.position.x, minpos.position.x),transform.position.y, transform.position.z);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x - inc, maxpos.position.x, minpos.position.x), transform.position.y, transform.position.z);
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene(0);
    }




}
