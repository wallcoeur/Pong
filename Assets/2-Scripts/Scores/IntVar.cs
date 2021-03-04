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
        public int m_value;
    }
}