using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private bool left = false;
    private bool right = false;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        if(left==true)
        {
            left = false;
            right = true;

        }
        if(right==true)
        {
            right = false;
            left = true;
        }
    }
}
