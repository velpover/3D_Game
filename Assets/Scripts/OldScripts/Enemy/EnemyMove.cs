
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{
    private Transform target;
    private AnimateEnemy _animat;
    private NavMeshAgent _agent;

    private float _attackDistance = 2.5f;
    private bool _done = false;
    

    void Start()
    {
        _agent=GetComponent<NavMeshAgent>();

        _animat = GetComponent<AnimateEnemy>();
    }

    void Update()
    {
        if (_done)
        {
            gameObject.GetComponent<NavMeshAgent>().SetDestination(target.position);
        }

        
    }
    public void MoveTo(Transform target,float dis)
    {
        _animat.Move();
        if (dis < _attackDistance)
        {
            _animat.Attack();
        }
        this.target=target;

        _done = true;
    }
}
