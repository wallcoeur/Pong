/*--------------------------------------------------------------|
|    Author : Iohannes Mbooumba                                 |
|    Nickname : Eldersys                                        |
|    Date of creation : 01/03/2021                              |
|---------------------------------------------------------------*/

using UnityEngine;
using WoolySheep.Player.InputControllers;

namespace WoolySheep.Player.Kinematics
{
    [RequireComponent(typeof(SecondPlayerController), typeof(BoxCollider2D), typeof(Rigidbody2D))]
    public sealed class SecondPlayerKinematic : BasePlayerKinematic
    {
        private void Awake()
        {
            m_controller = GetComponent<SecondPlayerController>();
        }
    }
}