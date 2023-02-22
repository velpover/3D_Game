using UnityEngine;

public class StandaloneInput : IGameInput
{
    public float HorizontalInput { get; private set; }
    public float VerticalInput { get; private set; }
    public bool AttackInputDown { get; private set; }
    public bool AttackInputUp { get; private set; }


    public void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
        VerticalInput = Input.GetAxis("Vertical");
        AttackInputDown = Input.GetKeyDown(KeyCode.E);
        AttackInputUp = Input.GetKeyUp(KeyCode.E);
    }
}
