/*--------------------------------------------------------------|
|    Author : Iohannes Mbooumba                                 |
|    Nickname : Eldersys                                        |
|    Date of creation : 01/03/2021                              |
|---------------------------------------------------------------*/

using UnityEngine;
using WoolySheep.PlayerSystem.InputControllers;

namespace WoolySheep.PlayerSystem.Kinematics
{
    [RequireComponent( typeof(BoxCollider2D), typeof(Rigidbody2D))]
    public sealed class FirstPlayerKinematic : BasePlayerKinematic
    {
        private void Awake()
        {
            // Give the correct controller for this kinematic
            m_baseController = GetComponent<FirstPlayerBaseController>();
        }
    }
}