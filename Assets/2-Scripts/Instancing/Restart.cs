using UnityEngine;
using UnityEngine.SceneManagement;
using WoolySheep.Scores;

namespace WoolySheep.Instancing
{
    public class Restart : MonoBehaviour
    {
        public IntVar m_p1;
        public IntVar m_p2;
        
        public void RestartGame()
        {
            m_p1.m_value = 0;
            m_p2.m_value = 0;
            
            string p_scene = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(p_scene);
        }
    }
}
