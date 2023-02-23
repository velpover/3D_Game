using System.Collections;
using UnityEngine;

public class AnimateEnemy : MonoBehaviour
{
    private Animator _animator;
    private bool _isAnimating;

    void Start()
    {
        _animator= GetComponent<Animator>();
    }

    public void TakeDamage()
    {
        _animator.SetBool("GetHit",true);
        
        StartCoroutine(ChangeAnimate("GetHit"));
    }

    public void Move()
    {
        _animator.SetBool("Move",true);
    }

    public void Attack()
    {
        _animator.SetBool("Attack",true);

        StartCoroutine(ChangeAnimate("Attack"));
    }

    public void Dead()
    {   
        _animator.SetBool("Move",false);
        _animator.SetBool("isDead",true);
    }

    IEnumerator ChangeAnimate(string name)
    {
        yield return new WaitForSeconds(0.5f);
        _animator.SetBool(name,false);
    }
}
