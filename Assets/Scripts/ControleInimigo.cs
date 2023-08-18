using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ControleInimigo : MonoBehaviour
{
    [SerializeField] NavMeshAgent _agent;
    [SerializeField] Transform[] _pos;
    [SerializeField] int _numberPos;
    [SerializeField] private float _distanciaRestante;
    [SerializeField] private bool _checkPos;

    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();    
    }

    
    void Update()
    {
        _agent.destination = _pos[_numberPos].transform.position;
        //UnityEngine.Debug.Log(_agent.remainingDistance);
        _distanciaRestante = _agent.remainingDistance;
        if (_distanciaRestante < 5 && _checkPos == false)
        {
            _checkPos = true;
            _numberPos++;
            Invoke("TimeCheckPos", 2f);
        }
        if (_numberPos > 3)
        {
            _numberPos = 0;
        }
    }
    void TimeCheckPos()
    {
        _checkPos = false;
    }
}
