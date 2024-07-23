using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementAndControl : MonoBehaviour
{

    public float speed = 10.5f;


    // Update is called once per frame
    void Update()
    {
       Vector3 pos = transform.position;
    
        {
            pos.z += speed * Time.deltaTime;
        }
        transform.position = pos;
    } 
    
   
}