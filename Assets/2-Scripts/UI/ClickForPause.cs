using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Pong.UI
{
    public class ClickForPause : MonoBehaviour
    {
        [SerializeField] private GameObject m_pauseMenu;

        // Update is called once per frame
        private void Update()
        {
            if (Input.GetKey(KeyCode.Escape)) { StartCoroutine(DisplayPause()); }
        }

        private IEnumerator DisplayPause()
        {
            // Pause the time of the game
            Time.timeScale = 0;
            
            m_pauseMenu.SetActive(true);
            float p_scaleX = m_pauseMenu.transform.localScale.x;

            while (p_scaleX < 1)
            {
                yield return new WaitForEndOfFrame();
                
                p_scaleX = Mathf.Lerp(p_scaleX, 1, 0.05f);
                m_pauseMenu.transform.localScale = new Vector3(p_scaleX, 1, 1);
            }
            
        }
        
        #region Hide Pause
        
        public void HidePause()
        {
            StartCoroutine(HidePauseRoutine());
            
            // Resume the time of the game
            Time.timeScale = 1;
        }

        private IEnumerator HidePauseRoutine()
        {
            float p_scaleX = m_pauseMenu.transform.localScale.x;

            while (p_scaleX > 0)
            {
                yield return new WaitForEndOfFrame();
                
                p_scaleX = Mathf.Lerp(p_scaleX, 0, 0.1f);
                m_pauseMenu.transform.localScale = new Vector3(p_scaleX, 1, 1);
            }
            m_pauseMenu.SetActive(false);
        }

        #endregion
        
    }
}
