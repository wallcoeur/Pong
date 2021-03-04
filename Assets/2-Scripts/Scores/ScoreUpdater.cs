/*--------------------------------------------------------------|
|    Author : Iohannes Mbooumba                                 |
|    Date of creation : XX/XX/20XX                              |
|---------------------------------------------------------------*/

using TMPro;
using UnityEngine;

namespace WoolySheep.Scores
{
    public class ScoreUpdater : MonoBehaviour
    {
        /// <summary> The value of the score </summary>
        [Tooltip("The value of the score")][SerializeField] public IntVar m_score;
        
        /// <summary> The text to update with the score </summary>
        [Tooltip("The text to update with the score")][SerializeField] public TextMeshProUGUI m_text;

        private void Update()
        {
            // Display the score in the text
            m_text.text = m_score.m_value.ToString();
        }
    }
}