
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    readonly float _rotSpeed=4f;
    private float _rotY;
    private float _comebackRotate;

    [SerializeField] private Transform target;

    
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            _rotY = Input.GetAxis("Mouse X") * _rotSpeed;
            
            transform.RotateAround(target.position, Vector3.up, _rotY);

            _comebackRotate -= _rotY;
        }
        else if (Input.GetMouseButtonUp(1))
        {
            transform.RotateAround(target.position,Vector3.up, _comebackRotate);
            _comebackRotate = 0;
        }

    }
}
