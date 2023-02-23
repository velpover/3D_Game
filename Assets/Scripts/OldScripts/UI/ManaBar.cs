
using UnityEngine;

public class ManaBar : MonoBehaviour
{
    private Vector3 _localScaleX = Vector3.one;

    private float _maxMana = 10f;

    public void ChangeManaBar(float mana)
    {
        _localScaleX.x = mana*0.1f; 

        transform.localScale = _localScaleX;
       
    }

    public void Active()
    {
        gameObject.SetActive(true);
    }

    public void SwitchOff()
    {
        gameObject.SetActive(false);
    }

    public void AddMana(ref float _mana)
    {
        if (_mana < _maxMana)
        {
            _mana ++;

            Active();
            ChangeManaBar(_mana);
        }

        else if (_mana >= _maxMana)
        {
            SwitchOff();
        }
    }
}
