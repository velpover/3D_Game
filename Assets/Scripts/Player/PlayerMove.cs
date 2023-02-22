
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private CharacterController _CharacterController;
    private IGameInput _gameInput;
    private float _rotateY;
    readonly float _rotateSpeed = 2f;
    private float _posX;
    private float _posZ;
    private float velocity=5f;

    void Start()
    {
        _gameInput = InputManager.Instance.GameInput;
        _CharacterController=GetComponent<CharacterController>();
    }
    void Update()
    {
        _rotateY = _gameInput.HorizontalInput;
        transform.Rotate(Vector3.up,_rotateY*_rotateSpeed);

        _posX = _rotateY * velocity;
        _posZ = _gameInput.VerticalInput * velocity;

        Vector3 moves = new Vector3(_posX,0,_posZ);
        moves *= Time.deltaTime;

        moves=transform.TransformDirection(moves);
        _CharacterController.Move(moves);


    }
}
