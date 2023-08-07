using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListaSimples : MonoBehaviour
{
    [SerializeField] GameObject[] _cubos; // MATRIZ = CONSEGUE ATRIBUIR DADOS
    [SerializeField] List<GameObject> _cubosL; // LISTA = CONSEGUE ATRIBUIR UM NUMEROSA POPULAÇÃO DE GAMEOBJECTS

    void Start()
    {
        for (int i = 0; i < _cubos.Length; i++)
        {
            _cubos[i].gameObject.SetActive(true);
            _cubos[i].transform.localScale = new Vector3 (2, 2, 2);
            _cubos[i].transform.localEulerAngles = new Vector3 (45, 45, 45);
            _cubosL.Add(_cubos[i]);
        }
    }

    
    void Update()
    {
        
    }
}
