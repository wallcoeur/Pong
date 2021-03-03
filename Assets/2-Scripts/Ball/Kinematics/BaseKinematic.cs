/*--------------------------------------------------------------|
|    Author : Iohannes Mbooumba                                 |
|    Nickname : Eldersys                                        |
|    Date of creation : 28/02/2021                              |
|---------------------------------------------------------------*/

using UnityEngine;

namespace Pong.Ball.Kinematics
{
    [RequireComponent(typeof(Rigidbody2D))]
    public abstract class BaseKinematic : MonoBehaviour
    {
        //--------------------------- Public variables ---------------------------//
        
        ///<summary> Represent the speed </summary>
        [Tooltip("Represent the speed of the ball")][SerializeField] public float m_speed;
        
        //--------------------------- Hidden variables ---------------------------//
        
        ///<summary> Represent the direction of the ball </summary>
        [HideInInspector][SerializeField] public Vector2 m_direction;
        
        //--------------------------- Methods ---------------------------//
        
        //When the script is loaded, we give an initial direction
        public virtual void Awake()
        {
            m_direction = new Vector2(Mathf.Sign(Random.Range(-1, 1)), Mathf.Sign(Random.Range(-1, 1)));
        }
        
        /// <summary> This method apply the movement </summary>
        protected virtual void ApplyKinematic()
        {
            //Apply the movement
            transform.Translate(m_direction * (m_speed * Time.deltaTime), Space.World);
        }
        
        //When the ball touches something, give it the opposite direction
        public virtual void OnCollisionEnter2D(Collision2D p_other)
        {
            // Get the contact normal
            Vector2 p_hit = p_other.contacts[0].normal;
            
            // Get the angle of the contact normal we've hit
            float p_angle = Vector2.Angle(p_hit, Vector2.up);
            
            // Check the sides and modify the direction accordingly
            if (Mathf.Approximately(p_angle, 0)) { m_direction.y *= -1; } // If touches down, we go up
            if(Mathf.Approximately(p_angle, 180)) { m_direction.y *= -1; } // If touches up, we go down
            if(Mathf.Approximately(p_angle, 90)) { m_direction.x *= -1; } // If touches a side, we go back in x
        }
    }
}