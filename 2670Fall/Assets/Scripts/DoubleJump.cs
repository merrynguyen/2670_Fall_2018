using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;

public class DoubleJump: MovePattern {
//for grounded or not grounded
    

    private bool doubleJump;

    public override void Invoke(CharacterController controller, Transform tranform)
    {
        if (controller.isGrounded)
        {
            Move(tranform);
            doubleJump = true;
        }

        if (doubleJump)
        {
         moveDirection.y = MoveY.Value;
            doubleJump = false;

        }

       Move(controller);
    }
    }

