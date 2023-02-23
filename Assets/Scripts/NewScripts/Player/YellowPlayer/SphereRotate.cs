using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereRotate : MonoBehaviour
{
    [SerializeField] private Transform _player;

    private float _rotateVelocity = 2f;
    void FixedUpdate()
    {
        transform.RotateAround(_player.position,Vector3.up,_rotateVelocity );
    }
}
