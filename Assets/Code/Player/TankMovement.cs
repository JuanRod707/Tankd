using System.Collections;
using System.Collections.Generic;
using Assets.Code.Input;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Networking;

namespace Assets.Code.Player
{
    public class TankMovement : NetworkBehaviour
    {
        public float Speed;
        private NavMeshAgent agent;
        private MovementInput input;

        void Update()
        {
            if (hasAuthority)
            {
                MoveTank(input.ReadXYAxis);
            }
        }

        void Start()
        {
            input = GetComponent<MovementInput>();
            agent = GetComponent<NavMeshAgent>();
        }

        void MoveTank(Vector2 moveVector)
        {
            var movementVector = new Vector3(moveVector.x, 0f, moveVector.y); 
            agent.SetDestination(transform.position + movementVector);
        }
    }
}
