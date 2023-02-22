using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NewScene
{
    public class RotateCamera : MonoBehaviour
    {
        [SerializeField] private Transform target; 

        private float _rotateY;
        private float _velocityRotate=1.5f;


        private Vector3 _cameraPosition = new Vector3(0, 4, -10);


        void Update()
        {
            transform.position = target.position + _cameraPosition;

            if (Input.GetMouseButtonDown(0))
            {
                Cursor.visible = false;
            }

            _rotateY = Input.GetAxis("Mouse X");

            if (_rotateY != 0)
            {
                transform.RotateAround(target.position,Vector3.up,_rotateY*_velocityRotate);

                target.rotation = Quaternion.Slerp(target.rotation, transform.rotation, 0.1f);
            }
        }
    }

}
