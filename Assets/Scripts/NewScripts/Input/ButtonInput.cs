using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInput : MonoBehaviour
{
    public event Action redPlayerClick;
    public event Action blackPlayerClick;
    public event Action yellowPlayerClick;

    public void RedPlayerClick()
    {
        redPlayerClick?.Invoke();
    }

    public void YellowPlayerClick()
    {   
        yellowPlayerClick?.Invoke();
    }

    public void BlackPlayerClick()
    {
        blackPlayerClick?.Invoke();
    }

}
