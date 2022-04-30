using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


namespace VampLike
{
    public class GameManager : MonoSingleton<GameManager>
    {
        public PlayerInput input;

        void Start()
        {
            input = GetComponent<PlayerInput>();
        }
    }
}