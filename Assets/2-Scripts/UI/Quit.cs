/*--------------------------------------------------------------|
|    Author : Iohannes Mbooumba                                 |
|    Date of creation : 04/03/2021                              |
|---------------------------------------------------------------*/

using UnityEngine;
using UnityEngine.SceneManagement;

namespace WoolySheep.UI
{
    public class Quit : MonoBehaviour
    {
        /// <summary> The quit to menu function bind to a button</summary>
        public void QuitToMenu()
        {
            // Load the main menu scene
            SceneManager.LoadScene("Main-Menu");
        }
        
        /// <summary> The quit application function bind to a button</summary>
        public void QuitApplication()
        {
            Application.Quit();
        }
    }
}