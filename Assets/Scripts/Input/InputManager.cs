using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance { get; private set; }
    
    public IGameInput GameInput { get; private set; }

    private void Awake()
    {
        Instance = this;
        CreateGameInput();
    }

    private void Update()
    {
        GameInput.Update();
    }

    private void CreateGameInput()
    {
#if UNITY_EDITOR
        GameInput = new StandaloneInput();
#else
        GameInput = new MobileInput():
#endif
    }
}
