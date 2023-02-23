
using UnityEngine;
using UnityEngine.AI;

public class EnemyHelthChange : MonoBehaviour
{
    public float EnemyHelth = 3f;

    private AnimateEnemy _animator;
    private Collider _collider;
    private NavMeshAgent _agent;

    public bool isStatic = false;

    [SerializeField] private ParticleSystem partSyst;

    void Start()
    {
        _animator = GetComponent<AnimateEnemy>();

        _collider = GetComponent<Collider>();

        if(!isStatic)
            _agent = GetComponent<NavMeshAgent>();
    }

    public float Damage(ref float mana)
    {
        EnemyHelth--;
        if (EnemyHelth <= 0)
        {
            _animator.Dead();

            _agent.Stop();

            Destroy(_collider);
            Destroy(gameObject,2f);
        }

        partSyst.Play();

        _animator.TakeDamage();

        mana-=2f;
        return mana;

    }

   
}
