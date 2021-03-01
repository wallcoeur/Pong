/*--------------------------------------------------------------|
|    Author : Iohannes Mbooumba                                 |
|    Nickname : Eldersys                                        |
|    Date of creation : 28/02/2021                              |
|---------------------------------------------------------------*/

using Pong.Ball.Kinematics;
using UnityEngine;

namespace Pong.Ball.Shapes
{
    [RequireComponent(typeof(Rigidbody2D), typeof(CircleCollider2D))]
    public class CircleBaseKinematic : BaseKinematic
    {
        //--------------------------- Methods ---------------------------//
        
        //Move the object to another random direction
        private void Update()
        {
            ApplyKinematic();
        }
    }
}