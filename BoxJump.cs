using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

public class BoxJump : MonoBehaviour
{
    protected float Animation;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            GetComponent<ParabolaController>().FollowParabola();
    }
}
