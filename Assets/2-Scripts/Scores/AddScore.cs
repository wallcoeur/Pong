using UnityEngine;
using WoolySheep.Instancing;

namespace WoolySheep.Scores
{
    public class AddScore : MonoBehaviour
    {
        [SerializeField] private IntVar m_points;
        [SerializeField] private SpawnOnce m_respawn;
        private void OnTriggerEnter2D(Collider2D p_other)
        {
            m_points.m_value += 1;
            m_respawn.Respawn();
        }
    }
}
