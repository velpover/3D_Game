
public interface IGameInput 
{
    float HorizontalInput { get; }
    float VerticalInput { get; }
    bool AttackInputDown { get; }
    bool AttackInputUp { get; }
    void Update();
}
