using UnityEngine;

namespace Pong.Ball
{
    public class TriangleBallMovement : BallMovement
    {
        public float m_rotationSpeed;

        private void Start()
        {
            RandomMovement();
        }

        private void Update()
        {
            //Give a rotation to the square
            transform.Rotate(Vector3.forward * (m_rotationSpeed * Time.deltaTime));
            transform.Translate(RandomMovement() * (m_speed * Time.deltaTime));
        }
        
        public override Vector2 RandomMovement()
        {
            return m_direction;
        }
    }
}