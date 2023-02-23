
using UnityEditor.Macros;
using UnityEngine;
using UnityEngine.AI;


public abstract class AbstrackEnemy:MonoBehaviour
{
    protected  float EnemyHelth = 3f;
    protected float damage = 1f;

    protected NavMeshAgent agent;


    protected virtual void MoveTo(Transform target)
    {
        agent.SetDestination(target.position);
    }

    protected virtual void TakeDamage(float damage)
    {
        EnemyHelth-=damage;

        if (EnemyHelth <= 0)
        {
           
        }

    }


    protected virtual float Attack()
    {
        return damage;
    }
}
