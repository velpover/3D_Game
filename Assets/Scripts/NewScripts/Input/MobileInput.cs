using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileInput : IGameInput
{
    public float HorizontalInput { get; private set; }
    public float VerticalInput { get; private set; }
    public bool AttackInputAroundDown { get; private set; }
    public bool AttackInputAroundUp { get; private set; }
    public bool AttackInputFrontDown { get; private set; }
    public bool AttackInputFrontUp { get; private set; }


    public void Update()
    {

    }


}
