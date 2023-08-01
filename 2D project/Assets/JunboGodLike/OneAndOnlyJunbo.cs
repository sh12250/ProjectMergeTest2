using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneAndOnlyJunbo : MonoBehaviour
{
    private string hisName;
    // Start is called before the first frame update
    void Start()
    {
        hisName = "JunBo";
        hisName += "is God";
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Debug.Log(hisName);
    }
}
