using Pong.Player.InputControllers;
using UnityEngine;

namespace Pong.Player.Kinematics
{
    public abstract class BasePlayerKinematic : MonoBehaviour
    {
        //--------------------------- Public variables ---------------------------//
        
        /// <summary> The controller of this player </summary>
        [HideInInspector][Tooltip("The controller of this player")][SerializeField]
        public ControllerChecker m_controller;

        /// <summary> The speed of this player </summary>
        [Tooltip("The speed of this player")] [SerializeField]
        private float m_speed;
        

        // Update is called once per frame
        public virtual void Update()
        {
            transform.Translate(m_controller.InputDirection() * (m_speed * Time.deltaTime));
        }
    }
}