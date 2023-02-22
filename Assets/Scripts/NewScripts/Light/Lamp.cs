using System.Collections;
using System.Collections.Generic;
using NewScene;
using UnityEngine;

namespace NewScene
{
    [RequireComponent(typeof(KeyInput))]
    public class Lamp : MonoBehaviour
    {

        private float _maxSpotRange=40f;
        private float _minSpotRange=0f;
        private float _maxPointRange=8f;
        private float _minPointRange=2f;

        [SerializeField] private Light _lightPoint;
        [SerializeField] private Light _lightSpot;

        [SerializeField] private LightRange _lightRange;
        [SerializeField] private LightColor _lightColor;
        [SerializeField] private KeyInput _keyInput;


        void Awake()
        {
            _keyInput.KeyEDown +=() => _lightColor.OnColorChange(_lightPoint, _lightSpot);
           
            _keyInput.KeyEUP += () => _lightColor.OffColorChange(_lightPoint, _lightSpot);
            

            _keyInput.KeyQDown += () => _lightColor.OnColorChange(_lightPoint);
            _keyInput.KeyQDown += () => _lightRange.OnRangeChange(_lightPoint,_maxPointRange);
            _keyInput.KeyQDown += () => _lightRange.OffRangeChange(_lightSpot,_minSpotRange);
            

            _keyInput.KeyQUP += () => _lightColor.OffColorChange(_lightPoint);
            _keyInput.KeyQUP += () => _lightRange.OffRangeChange(_lightPoint,_minPointRange);
            _keyInput.KeyQUP +=() => _lightRange.OnRangeChange(_lightSpot,_maxSpotRange);
            

        }
        void OnDestroy()
        {
            _keyInput.ActionToNull();
        }


        private void LightOff(Light light)
        {
            light.gameObject.SetActive(false);
        }

        private void LightOn(Light light)
        {
            light.gameObject.SetActive(true);
        }

       
    }

}
