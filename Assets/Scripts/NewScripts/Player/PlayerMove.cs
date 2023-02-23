using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NewScene
{
    public class PlayerMove : MonoBehaviour
    {

        [SerializeField] private Rigidbody _rigidbody;

        private float _inputX;
        private float _inputY;
        private float _rotateY;
        private float _velocity = 20f;
        private float _rotateVelocity = 0.2f;

        private IGameInput _gameInput;


        void Start()
        {
            _gameInput = InputManager.Instance.GameInput;

        }

        void Update()
        {


            _inputX = _gameInput.VerticalInput;
            _inputY = _gameInput.HorizontalInput;

            _rotateY = Input.GetAxis("Mouse X");

            if (_inputX != 0)
            {
                _rigidbody.AddForce(transform.forward*_inputX*_velocity*Time.deltaTime,ForceMode.VelocityChange);
            }

            if (_inputY != 0)
            {
                _rigidbody.AddForce(transform.right*_inputY*_velocity * Time.deltaTime, ForceMode.VelocityChange);
            }



            if (_inputY!=0)
            {
                transform.Rotate(Vector3.up, _inputY*_rotateVelocity);
            }
            else if (_rotateY != 0)
            {
                transform.Rotate(Vector3.up, _rotateY );
            }

        }

    }

}

