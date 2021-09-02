/*--------------------------------------------------------------|
|    Author : Iohannes Mbooumba                                 |
|    Date of creation : 04/03/2021                              |
|---------------------------------------------------------------*/

using UnityEngine;
using UnityEngine.SceneManagement;

namespace WoolySheep.UI
{
    public class Launch : MonoBehaviour
    {
        /// <summary> The start function bind to a button</summary>
        public void StartGame()
        {
            // Load the game scene
            SceneManager.LoadScene("Pong-Vanilla");
        }
    }
}