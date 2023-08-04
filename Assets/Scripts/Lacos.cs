using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lacos : MonoBehaviour
{
    [SerializeField] float _numero;
    [SerializeField] float _length;
    [SerializeField] int[] _numeroM;

    void Start()
    {
        for (int i = 0; i < _length; i++)
        {
            _numero++; //_numero = _numero +1;
            if (i == 1)
            {
                Debug.Log("°o.O");
            }
        }

        // _numeroM[0] = 1;
        // _numeroM[1] = 1;
        // _numeroM[2] = 1;
        // _numeroM[3] = 1;

        //-----------------------------------------------------------------------

        /*
        for (int t = 0; t < _length + 1; t++)
        {
            _numeroM[t] = 1;

            // _numeroM[0] = 1;
            // _numeroM[1] = 5;
            // _numeroM[2] = 1;
            // _numeroM[3] = 1;

            if (t == 1)
            {
                _numeroM[t] = 5;
            }
            else
            {
                _numeroM[t] = 1;
            }
        }
        */

        //-----------------------------------------------------------------------
        Debug.Log("Tamanho da lista: "+_numeroM.Length);

        /*
        for (int i = 0; i < _length; i++)
        {   
            // Quando assumir a posição 1 na lista deve assumir o VAR++, senão VAR--
            //_numeroM[?]++; i==1
            //_numeroM[?]--; i==1

            if (i == 1)
            {
                _numeroM[1]++;
                //poderia ser tbm
                //_numeroM[i]++;
            }
            else
            {
                _numeroM[i]--;
            }
        }
        */

        for (int i = 0; i< _numeroM.Length; i++)
        {
            //posicao 1, seja valor 8
            //posicao 6, seja valor 9
            //posicao 2, seja valor 1
            //posicao 10, seja valor 33

            if (i == 1)
            {
                _numeroM[i] = 8;
            }
            else if (i == 6)
            {
                _numeroM[i] = 9;
            }
            else if (i == 2)
            {
                _numeroM[i] = 1;
            }
            else if (i == 10)
            {
                _numeroM[i] = 33;
            }
        }
    }

    
    void Update()
    {
        
    }
}
