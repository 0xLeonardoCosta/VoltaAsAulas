using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] NavMeshAgent _agent;
    [SerializeField] Transform _posPlayer;
    [SerializeField] float _speedGet;
    
    void Start()
    {
        _agent = gameObject.GetComponent<NavMeshAgent>();    
    }

    
    void Update()
    {
        _agent.destination = _posPlayer.position;
        _speedGet = Mathf.Abs(_agent.velocity.x + _agent.velocity.z);
    }
}
