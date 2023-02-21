
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LightAttack : MonoBehaviour
{
    private ColorChacheLight _lightChange;

    [SerializeField] private ManaBar _manaBar;
    [SerializeField] private Transform obj;

    private RaycastHit[] _hitsToMove = new RaycastHit[8];
    private RaycastHit[] _hitsToAttack = new RaycastHit[8];
    
    private float _maxDistance = 4f;
    private float _rayCastTimer;
    private float _maxTime = 0.5f;
    private float _mana=10;
    private bool _isKeyEActive = false;


    private Vector3 _correct = new(0, 3, 0);
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

            _lightChange.ColorChangeBlue();

        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            _isKeyEActive = false;

            _lightChange.ColorChangeYellow();

        }


        #endregion


        //_rayCastTimer += Time.deltaTime;

        //if (_rayCastTimer > _maxTime)
        //{

        //    _manaBar.AddMana(ref _mana);

        //    EnemyMoveToPlayer();

        //    AttackEnemyAround();


        //    _rayCastTimer = 0;

        //}

    }


    IEnumerator WaitSec()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.5f);
            _manaBar.AddMana(ref _mana);

            EnemyMoveToPlayer();

            AttackEnemyAround();
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



    //private void AttackEnemyAround()
    //{
    //    if (_isKeyEActive)
    //    {

    //        int k = Physics.BoxCastNonAlloc(transform.position + _correct, _cubeLight,
    //            Vector3.down, _hitsToAttack, Quaternion.identity, _maxDistance, 1 << 7);
    //        for (int i = 0; i < k; i++)
    //        {
    //            if (_mana > 0)
    //            {
    //                _hitsToAttack[i].collider.gameObject.GetComponent<EnemyHelthChange>()?.Damage(ref _mana);

    //                _manaBar.ChangeManaBar(_mana);
    //            }
    //            else
    //            {
    //                _lightChange.ColorChangeYellow();
    //            }

    //        }

    //    }
    //}

    private void AttackEnemyAround()
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
                    _hitsToAttack[i].collider.gameObject.GetComponent<EnemyHelthChange>()?.Damage(ref _mana);
                    Debug.Log("");
                    _manaBar.ChangeManaBar(_mana);
                }
                else
                {
                    _lightChange.ColorChangeYellow();
                }

            }

        }
    }

    public void GoTo(Dictionary<string,object> fd)
    {

    }




}
