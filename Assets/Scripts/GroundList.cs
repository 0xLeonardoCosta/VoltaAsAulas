using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundList : MonoBehaviour
{
    [SerializeField] Vector3 _posTemp;

    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            Invoke("AtivarGround", 2f);
        }
    }

    void Update()
    {
        
    }
    void AtivarGround()
    {
        GameObject bullet = CubePool.SharedInstance.GetPooledObject();
        if (bullet != null)
        {
            bullet.SetActive(true);
            //bullet.transform.position = new Vector3 (3, 3, 3);
            bullet.transform.localScale = new Vector3 (3, 3, 3);
            _posTemp = bullet.transform.position;
        }
    }
}
