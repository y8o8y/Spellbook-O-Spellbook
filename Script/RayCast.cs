using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    public bool isOver;
    public bool up;
    
    // Update is called once per frame
    void Update()
    {
        MouseClick();
    }

    #region Mouse
    public void MouseClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                GameObject hitObject = hit.collider.gameObject;
                Debug.Log("Hit Object" + hitObject.name + hitObject.layer);
            }
        }
    }
    #endregion
}
