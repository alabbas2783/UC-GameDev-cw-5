using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spwn : MonoBehaviour
{
    public Transform Maxpos;
    public Transform Medpos;
    public Transform Minpos;
    public int speed = 10;
    [SerializeField] GameObject Enemy;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawn", 1, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawn()
    {
     int Randompos=Random.Range(1,4); 
     if (Randompos == 1)
     {
     Instantiate(Enemy,Maxpos);
     }
     else if (Randompos == 2)
        {

            Instantiate(Enemy,Minpos);  
        }
     else if(Randompos == 3)
        {

            Instantiate(Enemy,Medpos);  
        }






    }





}
