public interface IGameInput
{
    float HorizontalInput { get; }
    float VerticalInput { get; }
    bool AttackInputAroundDown { get; }
    bool AttackInputAroundUp { get; }
    bool AttackInputFrontDown { get; }
    bool AttackInputFrontUp { get; }

    void Update();
}
