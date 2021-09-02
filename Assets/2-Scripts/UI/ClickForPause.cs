using System.Collections;
using UnityEngine;

namespace WoolySheep.UI
{
    public class ClickForPause : MonoBehaviour
    {
        /// <summary> The pause menu gameObject </summary>
        [Tooltip("The pause menu gameObject")][SerializeField] private GameObject m_pauseMenu;


        private void Update()
        {
            // If we launched the escape key, start displaying the menu
            if (Input.GetKey(KeyCode.Escape)) { StartCoroutine(DisplayPause()); }
        }
    
        /// <summary> Display the pause menu </summary>
        /// <returns></returns>
        private IEnumerator DisplayPause()
        {
            // Pause the time of the game
            Time.timeScale = 0;
            
            // Set the pause menu to true
            m_pauseMenu.SetActive(true);
            
            // Increase the scale of the menu until it fully appeared
            float p_scaleX = m_pauseMenu.transform.localScale.x;
            while (p_scaleX < 1)
            {
                yield return new WaitForEndOfFrame();
                
                p_scaleX = Mathf.Lerp(p_scaleX, 1, 0.05f);
                m_pauseMenu.transform.localScale = new Vector3(p_scaleX, 1, 1);
            }
            
        }
        
        #region Hide Pause
        
        /// <summary> Hide the pause menu </summary>
        public void HidePause()
        {
            StartCoroutine(HidePauseRoutine());
            
            // Resume the time of the game
            Time.timeScale = 1;
        }
        
        /// <summary> The routine to hide the pause menu </summary>
        private IEnumerator HidePauseRoutine()
        {
            // Decrease the scale of the pause menu
            float p_scaleX = m_pauseMenu.transform.localScale.x;
            while (p_scaleX > 0)
            {
                yield return new WaitForEndOfFrame();
                
                p_scaleX = Mathf.Lerp(p_scaleX, 0, 0.1f);
                m_pauseMenu.transform.localScale = new Vector3(p_scaleX, 1, 1);
            }
            
            // Set it to false
            m_pauseMenu.SetActive(false);
        }

        #endregion
        
    }
}
