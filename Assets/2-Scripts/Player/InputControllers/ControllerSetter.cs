/*--------------------------------------------------------------|
|    Author : Iohannes Mbooumba                                 |
|    Nickname : Eldersys                                        |
|    Date of creation :  28/02/2021                             |
|---------------------------------------------------------------*/

using System;
using UnityEngine;

namespace WoolySheep.Player.InputControllers
{
    public class ControllerSetter : MonoBehaviour
    {
        //--------------------------- Public variables ---------------------------//
        
        [HideInInspector][Tooltip("The name of the axis we move on")] [SerializeField] public string m_verticalAxis;
        [Tooltip("Select which player controller this player use")] [SerializeField] private SelectPlayerController m_playerController;
        
        //--------------------------- Methods ---------------------------//
        
        private void Awake()
        {
            switch (m_playerController)
            {
                case SelectPlayerController.FirstPlayerController:
                    m_verticalAxis = "FirstPlayerVertical";
                    break;
                case SelectPlayerController.SecondPlayerController:
                    m_verticalAxis = "SecondPlayerVertical";
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}