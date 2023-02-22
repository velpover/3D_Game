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

        private bool _isKeyPress = true;


        void Update()
        {

           
            if (Input.GetKeyDown(KeyCode.E) && !Input.GetKey(KeyCode.Q))
            {
                InvokeKeyDown(KeyEDown);
                
            }
            else if (Input.GetKeyUp(KeyCode.E) && !Input.GetKey(KeyCode.Q))
            {
                InvokeKeyUp(KeyEUP);
            }


             
            if (Input.GetKeyDown(KeyCode.Q) && !Input.GetKey(KeyCode.E))
            {
                InvokeKeyDown(KeyQDown);
            }
            else if (Input.GetKeyUp(KeyCode.Q) && !Input.GetKey(KeyCode.E))
            {
                InvokeKeyUp(KeyQUP);
               
            }

        }


        public void InvokeKeyDown(Action action)
        {
            action?.Invoke();
        }

        public void InvokeKeyUp(Action action)
        {
            action?.Invoke();
        }


        public void ActionToNull()
        { 
            
            KeyEDown=null;
            KeyEUP = null;

            KeyQDown = null;
            KeyQUP = null;
        }
    }

}
