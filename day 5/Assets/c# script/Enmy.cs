using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Enmy : MonoBehaviour
{
    Rigidbody rb;
    public int speed = 10;
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
        rb.velocity = new Vector3(0,0,-speed);

    }
     
  
}
