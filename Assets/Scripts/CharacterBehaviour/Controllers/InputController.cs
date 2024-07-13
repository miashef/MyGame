using UnityEngine;

namespace miashef
{
    public abstract class InputController : ScriptableObject
    {
        public abstract float RetrieveMoveInput();
        public abstract bool RetrieveJumpInput();
    }
}