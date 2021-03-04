/*--------------------------------------------------------------|
|    Author : Iohannes Mbooumba                                 |
|    Nickname : Eldersys                                        |
|    Date of creation :  28/02/2021                             |
|---------------------------------------------------------------*/

using UnityEngine;
using WoolySheep.Instancing.Interfaces;

namespace WoolySheep.Instancing
{
    public class SpawnOnce : MonoBehaviour, ISpawner
    {
        //--------------------------- Public variables ---------------------------//
        
        /// <summary> The object to spawn </summary>
        [Tooltip("The object to spawn, should be a prefab")] [SerializeField]private GameObject m_objectToSpawn;

        [HideInInspector] [SerializeField] public GameObject m_objectSpawned;
        
        //--------------------------- Hidden variables ---------------------------//

        //--------------------------- Methods ---------------------------//

        private void Awake()
        {
            Time.timeScale = 1;
        }

        //Instantiate the object at the position of the spawner
        private void Start()
        {
            Spawn();
        }

        public void Spawn()
        {
            m_objectSpawned = Instantiate(m_objectToSpawn, transform);
        }

        public void Respawn()
        {
            Destroy(m_objectSpawned);
            m_objectSpawned = Instantiate(m_objectToSpawn, transform);
        }
    }
}