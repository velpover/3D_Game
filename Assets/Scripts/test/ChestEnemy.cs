using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class ChestEnemy : AbstrackEnemy
{
    private void Awake()
    {
        
    }
    void Start()
    {
        EnemyHelth = 5;

        agent = GetComponent<NavMeshAgent>();

        

    }

    private EventManager ev = new EventManager();

    public void meth(GameObject obj)
    {

    }
    void Update()
    {
        
    }
}
