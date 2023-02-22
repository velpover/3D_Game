using System;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(HealthSystem))]
public class Enemy : MonoBehaviour
{
    [SerializeField] private HealthSystem _healthSystem;
    [SerializeField] private AnimateEnemy _animateEnemy;
    [SerializeField] private NavMeshAgent _agent;
    [SerializeField] private Collider _collider;
    [SerializeField] private ParticleSystem _damageVfx;

    private void Awake()
    {
        _healthSystem.OnCurrentHpValueChanged += CurrentHpValueChangedHandler;
        _healthSystem.OnDie += DieHandler;
    }

    private void OnDestroy()
    {
        _healthSystem.OnCurrentHpValueChanged -= CurrentHpValueChangedHandler;
        _healthSystem.OnDie -= DieHandler;
    }

    public void ApplyDamage(int damage) => _healthSystem.ApplyDamage(damage);

    private void CurrentHpValueChangedHandler(int value)
    {
        _damageVfx.Play();
        _animateEnemy.TakeDamage();
    }

    private void DieHandler()
    {
        _animateEnemy.Dead();
        _agent.isStopped = true;

        Destroy(_collider);
        Destroy(gameObject, 2f);
    }
}
