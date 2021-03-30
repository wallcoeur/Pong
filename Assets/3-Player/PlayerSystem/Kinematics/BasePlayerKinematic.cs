using UnityEngine;
using WoolySheep.PlayerSystem.InputControllers;

namespace WoolySheep.PlayerSystem.Kinematics
{
    public abstract class BasePlayerKinematic : MonoBehaviour
    {
        //--------------------------- Public variables ---------------------------//
        
        /// <summary> The controller of this player </summary>
        [HideInInspector][Tooltip("The controller of this player")][SerializeField]
        public BaseController m_baseController;

        /// <summary> The speed of this player </summary>
        [Tooltip("The speed of this player")] [SerializeField]
        private float m_speed;
        
        
        public virtual void Update()
        {
            // Move the player toward the direction of the input
            transform.Translate(m_baseController.InputDirection() * (m_speed * Time.deltaTime));
        }
    }
}