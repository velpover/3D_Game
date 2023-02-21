
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private CharacterController _CharacterController;


    private float _rotateY;
    readonly float _rotateSpeed = 2f;
    private float _posX;
    private float _posZ;
    private float velocity=5f;

    void Start()
    {
        _CharacterController=GetComponent<CharacterController>();
    }
    void FixedUpdate()
    {
        _rotateY = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up,_rotateY*_rotateSpeed);

        _posX = _rotateY * velocity;
        _posZ = Input.GetAxis("Vertical") * velocity;

        Vector3 moves = new Vector3(_posX,0,_posZ);
        moves *= Time.deltaTime;

        moves=transform.TransformDirection(moves);
        _CharacterController.Move(moves);


    }
}
