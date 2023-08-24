using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveInimigo : MonoBehaviour
{
    [SerializeField] NavMeshAgent _agent;
    [SerializeField] ControlGame _controlGame;
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        _controlGame = Camera.main.GetComponent<ControlGame>();
    }

    
    void Update()
    {
        _agent.destination = _controlGame._alvo.position;
    }
}
