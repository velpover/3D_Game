using UnityEngine;

public class StandAloneInput : IGameInput
{
    public float HorizontalInput { get; private set; }
    public float VerticalInput { get; private set; }
    public bool AttackInputAroundDown { get; private set; }
    public bool AttackInputAroundUp { get; private set; }
    public bool AttackInputFrontDown { get; private set; }
    public bool AttackInputFrontUp { get; private set; }


    public void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
        VerticalInput = Input.GetAxis("Vertical");
        AttackInputAroundDown = Input.GetKeyDown(KeyCode.Q);
        AttackInputAroundUp = Input.GetKeyUp(KeyCode.Q);
        AttackInputFrontDown = Input.GetKeyDown(KeyCode.E);
        AttackInputFrontUp = Input.GetKeyUp(KeyCode.E);

    }
}