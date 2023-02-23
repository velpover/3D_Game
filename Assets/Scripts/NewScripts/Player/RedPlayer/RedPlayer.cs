
using System;
using UnityEngine;

public class RedPlayer : MonoBehaviour
{
    public float helth = 50f;
    public float _velocity = 1f;

    
    void OnEnable()
    {
        transform.position = PlayerSwap.SetActivePos();
    }

    void OnDisable()
    {
        PlayerSwap.TakeTransformPos(transform.position);
    }

}
