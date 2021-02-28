/*--------------------------------------------------------------|
|    Author : Iohannes Mbooumba                                 |
|    Nickname : Eldersys                                        |
|    Date of creation :  28/02/2021                             |
|---------------------------------------------------------------*/

using UnityEngine;

namespace Pong.Ball
{
    public class BallSpawner : MonoBehaviour
    {
        //--------------------------- Public variables ---------------------------//
        
        /// <summary> The position of the spawn </summary>
        [Tooltip("The position of the spawn")] [SerializeField]private Transform m_spawnPosition;
        
        /// <summary> The object to spawn </summary>
        [Tooltip("The object to spawn")] [SerializeField]private GameObject m_objectToSpawn;
        
        //--------------------------- Hidden variables ---------------------------//

        //--------------------------- Methods ---------------------------//
        
        //Instantiate the object at the position of the spawner
        private void Start()
        {
            Instantiate(m_objectToSpawn, m_spawnPosition);
        }
    }
}