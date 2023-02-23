using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NewScene
{
    public class KeyInput : MonoBehaviour
    {
        public event Action KeyEDown;
        public event Action KeyEUP;

        public event Action KeyQDown;
        public event Action KeyQUP;

        private bool _isFront = false;
        private bool _isAround = false;

        private IGameInput _gameInput;

        void Start()
        {
            _gameInput = InputManager.Instance.GameInput;
        }


        void Update()
        {

           
            if (_gameInput.AttackInputFrontDown && !_isAround)
            {
                KeyEDown?.Invoke();
                _isFront = true;

            }
            else if (_gameInput.AttackInputFrontUp && !_isAround)
            {
                KeyEUP?.Invoke();
                _isFront = false;
            }

             
            if (_gameInput.AttackInputAroundDown && !_isFront)
            {
                KeyQDown?.Invoke();
                _isAround = true;
            }
            else if (_gameInput.AttackInputAroundUp && !_isFront)
            {
                KeyQUP?.Invoke();
                _isAround = false;

            }

        }

    }

}
