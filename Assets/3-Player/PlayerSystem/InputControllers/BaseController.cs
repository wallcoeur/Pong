/*--------------------------------------------------------------|
|    Author : Iohannes Mbooumba                                 |
|    Nickname : Eldersys                                        |
|    Date of creation :  28/02/2021                             |
|---------------------------------------------------------------*/

using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace WoolySheep.PlayerSystem.InputControllers
{
    [RequireComponent(typeof(BoxCollider2D), typeof(Rigidbody2D))]
    public abstract class BaseController : MonoBehaviour
    {
        [FormerlySerializedAs("m_setPLayerController")] [Tooltip("This is the setter for the controller")] public Controller m_setPlayerController;
        
        
        //--------------------------- Methods ---------------------------//
        public void Awake()
        {
            m_setPlayerController.CheckController();
        }

        public virtual void Update()
        {
            InputDirection();
        }
        
        /// <summary> Give the input direction </summary>
        /// <returns> a Vector2 direction</returns>
        public virtual Vector2 InputDirection()
        {
            Vector2 p_inputs = new Vector2(0, Input.GetAxis(m_setPlayerController.m_verticalAxis));
            return p_inputs;
        }


        [Serializable]
        public class Controller
        {
            [HideInInspector][Tooltip("The name of the axis we move on")] [SerializeField] public string m_verticalAxis;
            [Tooltip("Select which player controller this player use")] [SerializeField] private SelectPlayerController m_controller;
            
            public void CheckController()
            {
                switch (m_controller)
                {
                    case SelectPlayerController.FirstPlayerController:
                        m_verticalAxis = "FirstPlayerVertical";
                        break;
                    case SelectPlayerController.SecondPlayerController:
                        m_verticalAxis = "SecondPlayerVertical";
                        break;
                    case SelectPlayerController.BreakoutPlayerController:
                        m_verticalAxis = "BreakoutPlayerVertical";
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }
        
    }
}
