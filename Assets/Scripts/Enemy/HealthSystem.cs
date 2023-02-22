using System;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public event Action<int> OnCurrentHpValueChanged;
    public event Action OnDie;
    
    [SerializeField] private int _maxHp = 100;
    private int _currentHp;
    private bool _isDead;

    private void Awake()
    {
        _currentHp = _maxHp;
    }

    public void ApplyDamage(int damage)
    {
        if (_isDead)
            return;
        
        _currentHp -= damage;

        if (_currentHp <= 0)
        {
            Die();
            return;
        }
        
        OnCurrentHpValueChanged?.Invoke(_currentHp);
    }

    public void Heal(int amount)
    {
        if (_isDead)
            return;
        
        _currentHp += amount;
        _currentHp = Mathf.Clamp(_currentHp, 0, _maxHp);
        
        OnCurrentHpValueChanged?.Invoke(_currentHp);
    }

    private void Die()
    {
        OnDie?.Invoke();
    }
}
