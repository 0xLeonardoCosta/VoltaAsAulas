using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using UnityEngine.Pool;

public class ListaInimigos : MonoBehaviour
{
    [SerializeField] float _posX = 1;
    void Start()
    {
        for (int i = 0; i < 7; i++)
        {
            Invoke("AtivarInimigos", .5f);
        }
    }

    
    void Update()
    {
        
    }

    void AtivarInimigos()
    {
        GameObject bullet = InimigoPool.SharedInstance.GetPooledObject();
        if (bullet != null)
        {
            bullet.SetActive(true);
            bullet.transform.localPosition = new Vector3(_posX,0,0);
            _posX++;
        }
    }
}
