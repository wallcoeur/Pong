using Pong.Player.InputControllers;
using UnityEngine;

namespace Pong.Player.Kinematics
{
    [RequireComponent(typeof(SecondPlayerController))]
    public class SecondPlayerKinematic : MonoBehaviour
    {
        //--------------------------- Public variables ---------------------------//
        
        public SecondPlayerController m_controller;
        
        //--------------------------- Methods ---------------------------//
        
        // Update is called once per frame
        private void Update()
        {
            transform.Translate(m_controller.InputDirection() * (5 * Time.deltaTime));
        }
    }
}