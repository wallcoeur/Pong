/*--------------------------------------------------------------|
|    Author : Iohannes Mbooumba                                 |
|    Date of creation : XX/XX/20XX                              |
|---------------------------------------------------------------*/

using System;
using TMPro;
using UnityEngine;

namespace Pong.Scores
{
    public class ScoreUpdater : MonoBehaviour
    {
        public IntVar m_score;
        public TextMeshProUGUI m_text;

        private void Update()
        {
            m_text.text = m_score.m_value.ToString();
        }
    }
}