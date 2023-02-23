using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance { get; private set; }

    public IGameInput GameInput { get; private set; }

    private void Awake()
    {
        Instance = this;
        CreateGameInput();
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        GameInput.Update();
    }

    private void CreateGameInput()
    {
#if UNITY_EDITOR
        GameInput = new StandAloneInput();
#else
        GameInput = new MobileInput();
#endif
    }
}