using System;
using UnityEngine;

public class YellowPlayer : MonoBehaviour
{
    public float helth = 100f;
    public float _velocity = 0.7f;


    void OnEnable()
    {
        transform.position = PlayerSwap.SetActivePos();
    }

    void OnDisable()
    {
        PlayerSwap.TakeTransformPos(transform.position);
    }
}
