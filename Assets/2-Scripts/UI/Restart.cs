using UnityEngine;
using UnityEngine.SceneManagement;
using WoolySheep.Scores;

namespace WoolySheep.UI
{
    public class Restart : MonoBehaviour
    {
        /// <summary> The Int var who check the score of the player 1 </summary>
        [Tooltip("The Int var who check the score of the player 1")][SerializeField] public IntVar m_p1;
        
        /// <summary> The Int var who check the score of the player 2 </summary>
        [Tooltip("The Int var who check the score of the player 2")][SerializeField] public IntVar m_p2;
        
        
        /// <summary> The restart function bind to a button</summary>
        public void RestartGame()
        {
            // Restart the scores of the game
            m_p1.m_value = 0;
            m_p2.m_value = 0;
            
            // Reload the scene
            string p_scene = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(p_scene);
        }
    }
}
