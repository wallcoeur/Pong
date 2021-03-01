/*--------------------------------------------------------------|
|    Author : Iohannes Mbooumba                                 |
|    Nickname : Eldersys                                        |
|    Date of creation :  28/02/2021                             |
|---------------------------------------------------------------*/

using Pong.Ball.Instancing.Interfaces;
using UnityEngine;

namespace Pong.Ball.Instancing
{
    public class SpawnOnce : MonoBehaviour, ISpawner
    {
        //--------------------------- Public variables ---------------------------//
        
        /// <summary> The object to spawn </summary>
        [Tooltip("The object to spawn, should be a prefab")] [SerializeField]private GameObject m_objectToSpawn;
        
        //--------------------------- Hidden variables ---------------------------//

        //--------------------------- Methods ---------------------------//
        
        //Instantiate the object at the position of the spawner
        private void Start()
        {
            Spawn();
        }

        public void Spawn()
        {
            Instantiate(m_objectToSpawn, transform);
        }
    }
}