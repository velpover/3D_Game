using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ButtonInput))]
public class PlayerSwap : MonoBehaviour
{
    [SerializeField] private GameObject _redPlayer;
    [SerializeField] private GameObject _yellowPlayer;
    [SerializeField] private GameObject _blackPlayer;

    [SerializeField] private ButtonInput _buttonInput;

    private static Vector3 _playerPos = Vector3.zero;

    void Awake()
    {
        _buttonInput.yellowPlayerClick += SetActiveYellowPlayer;

        _buttonInput.blackPlayerClick += SetActiveBlackPlayer;

        _buttonInput.redPlayerClick += SetActiveRedPlayer;
    }

    void OnDestroy()
    {
        _buttonInput.yellowPlayerClick -= SetActiveYellowPlayer;

        _buttonInput.blackPlayerClick -= SetActiveBlackPlayer;

        _buttonInput.redPlayerClick -= SetActiveRedPlayer;
    }

    private void SetActiveRedPlayer()
    {
        _redPlayer.SetActive(true);
        _yellowPlayer.SetActive(false);
        _blackPlayer.SetActive(false);
    }
    private void SetActiveYellowPlayer()
    {
        _redPlayer.SetActive(false);
        _yellowPlayer.SetActive(true);
        _blackPlayer.SetActive(false);
    }
    private void SetActiveBlackPlayer()
    {
        _redPlayer.SetActive(false);
        _yellowPlayer.SetActive(false);
        _blackPlayer.SetActive(true);
    }

    public static Vector3 SetActivePos()
    {
        return _playerPos;
    }
    public static void TakeTransformPos(Vector3 target)
    {
        _playerPos = target;
    }

}
