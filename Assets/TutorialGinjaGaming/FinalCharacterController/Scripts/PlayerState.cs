using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GinjaGaming.FinalCharacterController
{ 
    public class PlayerState : MonoBehaviour
    {

        public enum PlayerMovementState
        { 
            Idling = 0,
            Walking = 1,
            Running = 2,
            Sprinting = 3,
            Jumping = 4,
            Falling = 5,
            Strafing = 6,
        }

    }
}
