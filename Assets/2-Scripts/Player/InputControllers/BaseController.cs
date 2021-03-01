/*--------------------------------------------------------------|
|    Author : Iohannes Mbooumba                                 |
|    Nickname : Eldersys                                        |
|    Date of creation :  28/02/2021                             |
|---------------------------------------------------------------*/

using UnityEngine;
// ReSharper disable All

namespace Pong.Player.InputControllers
{
    public abstract class BaseController : MonoBehaviour
    {
        //--------------------------- Public variables ---------------------------//

        [Tooltip("The name of the axis we move on")] [SerializeField] private string m_verticalAxis;

        //--------------------------- Hidden variables ---------------------------//

        //--------------------------- Methods ---------------------------//

        public virtual Vector2 InputDirection()
        {
            Vector2 p_inputs = new Vector2(0, Input.GetAxis(m_verticalAxis));
            return p_inputs;
        }
    }
}
