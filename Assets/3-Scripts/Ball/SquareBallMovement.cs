/*--------------------------------------------------------------|
|    Author : Iohannes Mbooumba                                 |
|    Nickname : Eldersys                                        |
|    Date of creation : 28/02/2021                              |
|---------------------------------------------------------------*/

using UnityEngine;

namespace Pong.Ball
{
    [RequireComponent(typeof(Rigidbody2D), typeof(BoxCollider2D))]
    public class SquareBallMovement : BallMovement
    {
        //--------------------------- Public variables ---------------------------//

        /// <summary> Represent the speed of the rotation for the cube </summary>
        [Tooltip("Represent the speed of the rotation for the cube")] [SerializeField] public float m_rotationSpeed;
        private void Start()
        {
            RandomMovement();
        }

        private void Update()
        {
            //Give a rotation to the square
            transform.Rotate(Vector3.forward * (m_rotationSpeed * Time.deltaTime));
            
            //Apply the movement
            transform.Translate(RandomMovement() * (m_speed * Time.deltaTime), Space.World);
        }
        
        
        public override Vector2 RandomMovement()
        {
            return m_direction;
        }
    }
}