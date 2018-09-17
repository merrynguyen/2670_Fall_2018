using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class MovePatternNotGrounded : MovePattern {
    public override void Invoke(CharacterController controller, Transform transform)
    {
        Move(controller);
        Move(transform);
    }
}
