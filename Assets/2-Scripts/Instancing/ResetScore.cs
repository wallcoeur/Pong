using UnityEngine;
using WoolySheep.Scores;

namespace WoolySheep.Instancing
{
    public class ResetScore : MonoBehaviour
    {
        /// <summary> The score that should be reset </summary>
        [Tooltip("The score that should be reset")] [SerializeField] private IntVar m_scoreP1;
        
        /// <summary> The score that should be reset </summary>
        [Tooltip("The score that should be reset")] [SerializeField] private IntVar m_scoreP2;

        private void OnApplicationQuit()
        {
            // Reset the values of the score when we quit the game
            m_scoreP1.m_value = 0;
            m_scoreP2.m_value = 0;
        }
    }
}
