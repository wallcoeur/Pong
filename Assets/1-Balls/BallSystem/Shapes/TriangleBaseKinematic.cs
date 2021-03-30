/*--------------------------------------------------------------|
|    Author : Iohannes Mbooumba                                 |
|    Nickname : Eldersys                                        |
|    Date of creation : 28/02/2021                              |
|---------------------------------------------------------------*/

using UnityEngine;
using WoolySheep.BallSystem.Kinematics;

namespace WoolySheep.BallSystem.Shapes
{
    [RequireComponent(typeof(Rigidbody2D), typeof(PolygonCollider2D))]
    public class TriangleBaseKinematic : BaseKinematic
    {
        //--------------------------- Public variables ---------------------------//

        /// <summary> Represent the speed of the rotation for the triangle </summary>
        [Tooltip("Represent the speed of the rotation for the triangle")] [SerializeField] public float m_rotationSpeed;
        
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