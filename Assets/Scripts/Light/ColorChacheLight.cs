using System.Collections;
using UnityEngine;

public class ColorChacheLight : MonoBehaviour
{
    private Light _light;
    private Color _newBlue = new Color(0, 0.7f, 1);


    private float _maxRange = 12f;
    private float _defaultRange = 2f;

    private float _maxIntensity = 5f;
    private float _defaultIntensity = 3f;

    void Start()
    {
        _light = GetComponent<Light>();
    }

    public void ColorChangeBlue()
    {
        _light.color = _newBlue;
        _light.intensity = _maxIntensity;
        //StartCoroutine(GoToMaxRange());
    }


    public void ColorChangeYellow()
    {

        _light.intensity = _defaultIntensity;
        _light.color = Color.yellow;
        //StartCoroutine(GoToMinRange());
    }

    public void ChangeRange()
    {
        StartCoroutine(GoToMinRange());
    }


    IEnumerator GoToMaxRange()
    {
        while (_light.range < _maxRange)
        {
            _light.range++;
            yield return new WaitForSeconds(0.01f);
        }
    }


    IEnumerator GoToMinRange()
    {
        while (_light.range > _defaultRange)
        {
            _light.range--;
            yield return new WaitForSeconds(0.01f);
        }
    }

}
