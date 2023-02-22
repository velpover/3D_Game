public class MobileInput : IGameInput
{
    public float HorizontalInput { get; }
    public float VerticalInput { get; }
    public bool AttackInputDown { get; }
    public bool AttackInputUp { get; }

    public void Update()
    {
        throw new System.NotImplementedException();
    }
}
