using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace VampLike
{
    public class Player : MonoBehaviour
    {
        public void MoveInput(InputAction.CallbackContext context)
        {
            Debug.Log("move!");
        }
    }
}
