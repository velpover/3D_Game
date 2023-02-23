using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace NewScene
{
    public class LightRange : MonoBehaviour
    {
       
        public void OnRangeChange(Light light,float maxRange)
        {
            StartCoroutine(GoToMaxRange(light,maxRange));
        }

        public void OffRangeChange(Light light, float defaultRange)
        {
            StartCoroutine(GoToDefaultRange(light, defaultRange));
        }


        IEnumerator GoToMaxRange(Light light, float maxRange)
        {
            float point = maxRange / 10;
            while (light.range < maxRange)
            {   
                yield return new WaitForSeconds(0.01f);
                light.range+=point;
            }
        }

        IEnumerator GoToDefaultRange(Light light, float defaultRange)
        {   
            float point = light.range/10;
            while (light.range > defaultRange)
            {
                yield return new WaitForSeconds(0.01f);
                light.range -=point;
            }
        }

    }
}

