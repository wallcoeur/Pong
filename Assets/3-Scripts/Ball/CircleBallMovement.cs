/*--------------------------------------------------------------|
|    Author : Iohannes Mbooumba                                 |
|    Nickname : Eldersys                                        |
|    Date of creation : 28/02/2021                              |
|---------------------------------------------------------------*/

using UnityEngine;

namespace Pong.Ball
{
    [RequireComponent(typeof(Rigidbody2D), typeof(CircleCollider2D))]
    public class CircleBallMovement : BallMovement
    {
        private void Start()
        {
            RandomMovement();
        }

        private void Update()
        {
            transform.Translate(RandomMovement() * (m_speed * Time.deltaTime));
        }
        
        public override Vector2 RandomMovement()
        {
            return m_direction;
        }
    }
}