using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LacosBool : MonoBehaviour
{
    [SerializeField] bool[] _check;
    [SerializeField] bool _enemyCheck;

    [SerializeField] GameObject[] _enemy;

    void Start()
    {
        // 5 posicoes e todos serem true
        for (int i = 0; i < _check.Length; i++)
        {
            _check[i] = true;
        }
    }

    
    void Update()
    {
        for (int i = 0; i < _enemy.Length; i++)
        {
            _enemy[i].SetActive(_enemyCheck);
        }
    }
}
