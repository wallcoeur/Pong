using TMPro;
using UnityEngine;

namespace WoolySheep.Tools.UI
{
    public class PingPongAlpha : MonoBehaviour
    {
        /// <summary> The text that should ping pong </summary>
        [Tooltip("The text that should lerp")][SerializeField] private TextMeshProUGUI m_textToPingPong;
        
        //Cached color
        private Color m_color;

        // Update is called once per frame
        private void Update()
        {
            // We cache the color and ping pong it's alpha
            m_color = m_textToPingPong.color;
            m_color.a = Mathf.PingPong(Time.time, 1);
            
            // We then give back the color, with the ping ponging alpha
            m_textToPingPong.color = m_color;
        }
    }
}
