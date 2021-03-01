/*--------------------------------------------------------------|
|    Author : Iohannes Mbooumba                                 |
|    Nickname : Eldersys                                        |
|    Date of creation : XX/XX/20XX                              |
|---------------------------------------------------------------*/

using Pong.Player.InputControllers;
using UnityEngine;

namespace Pong.Player.Kinematics
{
    [RequireComponent(typeof(FirstPlayerController))]
    public class FirstPlayerKinematic : MonoBehaviour
    {
        //--------------------------- Public variables ---------------------------//
        
        public FirstPlayerController m_controller;
        
        //--------------------------- Methods ---------------------------//
        
        // Update is called once per frame
        void Update()
        {
            transform.Translate(m_controller.InputDirection() * (5 * Time.deltaTime));
        }
    }
}