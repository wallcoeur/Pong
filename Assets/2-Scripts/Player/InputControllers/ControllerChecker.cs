/*--------------------------------------------------------------|
|    Author : Iohannes Mbooumba                                 |
|    Nickname : Eldersys                                        |
|    Date of creation :  28/02/2021                             |
|---------------------------------------------------------------*/

using UnityEngine;

namespace WoolySheep.Player.InputControllers
{
    [RequireComponent(typeof(BoxCollider2D), typeof(Rigidbody2D), typeof(ControllerSetter))]
    public abstract class ControllerChecker : MonoBehaviour
    {
        [Tooltip("This is the setter for the controller")] public ControllerSetter m_setter;
        
        //--------------------------- Methods ---------------------------//

        public virtual void Update()
        {
            InputDirection();
        }
        
        public Vector2 InputDirection()
        {
            Vector2 p_inputs = new Vector2(0, Input.GetAxis(m_setter.m_verticalAxis));
            return p_inputs;
        }
        
    }
}
