using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class engine_rot : MonoBehaviour
{
     public bool isActive = false;
    Color activeColor = new Color();
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (isActive)
        {
        
            if (Input.touchCount == 1)
            {
                Touch screenTouch = Input.GetTouch(0);
                if (screenTouch.phase == TouchPhase.Moved)
                {
                    transform.Rotate(0f, screenTouch.deltaPosition.x, 0f);
                }
                if (screenTouch.phase == TouchPhase.Ended)
                {
                    isActive = false;
                }
            }
        }
        else
        {
           
        }
        GetComponent<MeshRenderer>().material.color = activeColor;
    }
}
