
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;


public class LightAttack : MonoBehaviour
{
    private ColorChacheLight _lightChange;

    [SerializeField] private ManaBar _manaBar;
    [SerializeField] private Transform obj;
    [SerializeField] private ColorChacheLight _pointLight;

    private RaycastHit[] _hitsToMove = new RaycastHit[8];
    private RaycastHit[] _hitsToAttack = new RaycastHit[8];
    
    private float _maxDistance = 4f;
    private float _rayCastTimer;
    private float _maxTime = 0.5f;
    private float _mana=10;
    private bool _isKeyEActive = false;


    private Vector3 _correct = new Vector3(0, 3, 0);
    private Vector3 _cubeCall = new Vector3(20, 0.1f, 20);
    private Vector3 _cubeLight = new Vector3(7f, 0.1f, 7f);


    void Start()
    {   
        _lightChange = GetComponent<ColorChacheLight>();
        StartCoroutine(WaitSec());
    }


    void Update()
    {
        #region  ChangeColorLight and Range of Light

        if (Input.GetKeyDown(KeyCode.E))
        {   
            _isKeyEActive=true;

            _pointLight.ColorChangeBlue();
            _lightChange.ColorChangeBlue();

        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            _isKeyEActive = false;

            _pointLight.ColorChangeYellow();
            _lightChange.ColorChangeYellow();

        }


        #endregion

    }


    IEnumerator WaitSec()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.5f);
            _manaBar.AddMana(ref _mana);

            EnemyMoveToPlayer();

            AttackEnemySpot();
        }
    }


    private void EnemyMoveToPlayer()
    {
        int j = Physics.BoxCastNonAlloc(transform.position + _correct, _cubeCall,
            Vector3.down, _hitsToMove, Quaternion.identity, _maxDistance, 1 << 7);

        for (int i = 0; i < j; i++)
        {
            _hitsToMove[i].collider.gameObject.GetComponent<EnemyMove>()
                ?.MoveTo(transform, _hitsToMove[i].distance);

        }
    }



    private void AttackEnemyAround()
    {
        if (_isKeyEActive)
        {

            int k = Physics.BoxCastNonAlloc(transform.position + _correct, _cubeLight,
                Vector3.down, _hitsToAttack, Quaternion.identity, _maxDistance, 1 << 7);
            for (int i = 0; i < k; i++)
            {
                if (_mana > 0)
                {
                    MakeDamage(_hitsToAttack[i].collider.gameObject);
                }
                else
                {
                    _lightChange.ColorChangeYellow();
                }

            }

        }
    }

    private void AttackEnemySpot()
    {
        if (_isKeyEActive)
        {
            Vector3 cubel = new Vector3(5, 0.1f, 5);
            int k = Physics.BoxCastNonAlloc(obj.position, cubel,
                Vector3.down, _hitsToAttack, Quaternion.identity, _maxDistance, 1 << 7);
            for (int i = 0; i < k; i++)
            {
                if (_mana > 0)
                {
                    MakeDamage(_hitsToAttack[i].collider.gameObject);
                }
                else
                {
                    _lightChange.ColorChangeYellow();
                }

            }
        }
    }

    private void MakeDamage(GameObject targetGo)
    {
        Enemy enemy = targetGo.GetComponent<Enemy>();

        if (enemy != null)
        {
            enemy.ApplyDamage(1);
            _mana--;
            _manaBar.ChangeManaBar(_mana);
        }
    }
}
