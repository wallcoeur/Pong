/*--------------------------------------------------------------|
|    Author : Iohannes Mbooumba                                 |
|    Nickname : Eldersys                                        |
|    Date of creation : 28/02/2021                              |
|---------------------------------------------------------------*/

using UnityEngine;
using WoolySheep.Ball.Kinematics;

namespace WoolySheep.Ball.Shapes
{
    [RequireComponent(typeof(Rigidbody2D), typeof(BoxCollider2D))]
    public class SquareBaseKinematic : BaseKinematic
    {
        //--------------------------- Public variables ---------------------------//

        /// <summary> Represent the speed of the rotation for the cube </summary>
        [Tooltip("Represent the speed of the rotation for the cube")] [SerializeField] public float m_rotationSpeed;
        
        //--------------------------- Methods ---------------------------//

        private void Update()
        {
            ApplyKinematic();
        }

        protected override void ApplyKinematic()
        {
            base.ApplyKinematic();
            
            //Give a rotation to the square
            transform.Rotate(Vector3.forward * (m_rotationSpeed * Time.deltaTime));
        }
    }
}