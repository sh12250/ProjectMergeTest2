using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeShimGreater : MonoBehaviour
{
    string hisName = default;

    private void Start()
    {
        hisName = "Shim";
    }

    private void Update()
    {
        if (hisName == "Shim")
        {
            hisName = "GodShim";
        }

        Debug.Log(hisName);
    }
}
