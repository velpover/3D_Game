using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NewScene
{
    public class LightColor : MonoBehaviour
    {

        private Color _blue  = new  Color(0.2f,0.7f,1f,1f);
        private Color _yellow = Color.yellow;

        public void OnColorChange(params Light[] lights)
        {
            for (int i = 0; i < lights.Length; i++)
                lights[i].color = _blue;
        }


        public void OffColorChange(params Light[] lights)
        {
            for (int i = 0; i < lights.Length; i++)
                lights[i].color = _yellow;
        }

    }
}
