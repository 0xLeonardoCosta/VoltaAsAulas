using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XInputDotNetPure;

public class Xvibration : MonoBehaviour
{
    PlayerIndex _playerIndex;
    GamePadState _state;
    GamePadState _prevState;

    [SerializeField] float[] _intensidade;

    void Start()
    {
        _intensidade[0] = 1f;
        _intensidade[1] = 0f;
    }

    void Update()
    {
        if (Input.GetKeyDown("joystick button 0"))
        {
            GamePad.SetVibration(_playerIndex, _intensidade[0], _intensidade[1]);
        }
        if (Input.GetKeyDown("joystick button 1"))
        {
            GamePad.SetVibration(_playerIndex, 0f, 0f);
        }
        if (Input.GetKeyDown("joystick button 2"))
        {
            // Aumenta a _intensidade em 0.1f sempre que pressionar o X
            _intensidade[0] += 0.1f;

            _intensidade[1] += 0.1f;

            // Se a _intensidade for maior a 1.0f, volte para 0.1f
            if (_intensidade[0] > 1.05f)
            {
                _intensidade[0] = 0.1f;
            }
            
            if (_intensidade[1] > 1.05f)
            {
                _intensidade[1] = 0.1f;
            }
        }
    }
}
