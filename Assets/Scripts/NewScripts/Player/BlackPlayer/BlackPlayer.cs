using System;
using System.Collections.Generic;
using UnityEngine;

public class BlackPlayer : MonoBehaviour
{
    public float health = 20f;
    public float velocity = 1.5f;


    void OnEnable()
    {
        transform.position=PlayerSwap.SetActivePos();
    }

    void OnDisable()
    {
        PlayerSwap.TakeTransformPos(transform.position);
    }
}
