using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveEnemy : MonoBehaviour
{
    [SerializeField] NavMeshAgent _agent;
    [SerializeField] Transform _player;

    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();    
    }

    
    void Update()
    {
        _agent.destination = _player.position;
    }
}
