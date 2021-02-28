/*--------------------------------------------------------------|
|    Author : Iohannes Mbooumba                                 |
|    Nickname : Eldersys                                        |
|    Date of creation : 28/02/2021                              |
|---------------------------------------------------------------*/

using UnityEngine;

namespace Pong.Ball
{
    [RequireComponent(typeof(Rigidbody2D))]
    public abstract class BallMovement : MonoBehaviour
    {
        //--------------------------- Public variables ---------------------------//
        
        ///<summary> Represent the speed </summary>
        [Tooltip("Represent the speed of the ball")][SerializeField] public int m_speed;
        
        //--------------------------- Hidden variables ---------------------------//
        
        ///<summary> Represent the direction of the ball </summary>
        [HideInInspector][SerializeField] public Vector2 m_direction;
        
        //--------------------------- Methods ---------------------------//
        
        public virtual void Awake()
        {
            m_direction = new Vector2(Mathf.Sign(Random.Range(-1, 1)), Mathf.Sign(Random.Range(-1, 1)));
        }
        
        /// <summary> Give a random movement/rotation to the object </summary>
        /// <returns> A random movement </returns>
        public abstract Vector2 RandomMovement();
        
    
        //When the ball touches something, give it the opposite direction
        public virtual void OnCollisionEnter2D()
        {
            m_direction *= -1;
        }
    }
}