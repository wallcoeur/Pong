/*--------------------------------------------------------------|
|    Author : Iohannes Mbooumba                                 |
|    Date of creation : XX/XX/20XX                              |
|---------------------------------------------------------------*/

using UnityEngine;

namespace WoolySheep.Scores
{
    [CreateAssetMenu(fileName = "IntVar", menuName = "Pong/Int Variable", order = 0)]
    public class IntVar : ScriptableObject
    {
        /// <summary> The actual value of the IntVar </summary>
        [Tooltip("The actual value of the IntVar")]public int m_value;
    }
}