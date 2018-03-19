using UnityEngine;

namespace Assets.Code.Input
{
    public class TurretInput : MonoBehaviour
    {
        public LayerMask GroundMask;

        public Vector3 GetMousePoint
        {
            get
            {
                var ray = Camera.main.ScreenPointToRay(UnityEngine.Input.mousePosition);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit, 100f, GroundMask))
                {
                    return hit.point;
                }

                return Vector3.zero;
            }
        }

        public bool ReadPrimaryFire
        {
            get { return UnityEngine.Input.GetButton("Fire_1"); }
        }

        public bool ReadSecondaryFire
        {
            get { return UnityEngine.Input.GetButton("Fire_2"); }
        }
    }
}
