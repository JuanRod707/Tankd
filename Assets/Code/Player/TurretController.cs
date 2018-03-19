using System.Collections;
using System.Collections.Generic;
using Assets.Code.Input;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Networking;

namespace Assets.Code.Player
{
    public class TurretController : NetworkBehaviour
    {
        public float RotationSpeed;

        private TankMovement parentClient;
        private TurretInput input;
        private Vector3 aimTo;

        void Update()
        {
            if (parentClient.hasAuthority)
            {
                AimTurret(input.GetMousePoint);
            }
        }

        void Start()
        {
            parentClient = GetComponentInParent<TankMovement>();
            input = GetComponent<TurretInput>();
            aimTo = transform.forward;
        }

        void AimTurret(Vector3 aimPoint)
        {
            aimTo = Vector3.Lerp(aimTo, aimPoint, RotationSpeed);
            transform.LookAt(aimTo);

            var euler = transform.eulerAngles;
            euler.x = 0f;
            euler.z = 0f;

            transform.eulerAngles = euler;
        }
    }
}
