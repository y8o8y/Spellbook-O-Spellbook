using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnPlayerScriptBase : MonoBehaviour
{
    [SerializeField]
    float rotateSpeed;
    [SerializeField]
    Vector3 rotateDirection = new Vector3();
    //Update is called once per frame
    void Update()
    {
        transform.Rotate(rotateSpeed*rotateDirection*Time.deltaTime);
    }
}
