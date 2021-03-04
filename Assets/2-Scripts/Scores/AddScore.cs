using UnityEngine;
using UnityEngine.Serialization;
using WoolySheep.Instancing;

namespace WoolySheep.Scores
{
    public class AddScore : MonoBehaviour
    {
        /// <summary> The points to add </summary>
        [Tooltip("The points to add")][SerializeField] private IntVar m_points;
        
        /// <summary> The spawner of the ball </summary>
        [Tooltip("The spawner of the ball")][FormerlySerializedAs("m_respawn")] [SerializeField] private SpawnOnce m_spawner;
        
        
        private void OnTriggerEnter2D(Collider2D p_other)
        {
            // Add the point and respawn the ball
            
            m_points.m_value += 1;
            m_spawner.Respawn();
        }
    }
}
