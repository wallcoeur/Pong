using UnityEngine;
using WoolySheep.PlayerSystem.InputControllers;

namespace WoolySheep.PlayerSystem.Kinematics
{
    [RequireComponent(typeof(BreakoutBaseController), typeof(BoxCollider2D), typeof(Rigidbody2D))]
    public class BreakoutPlayerKinematic : BasePlayerKinematic
    {
        private void Awake()
        {
            // Give the correct controller for this kinematic
            m_baseController = GetComponent<BreakoutBaseController>();
        }
        
    }
}