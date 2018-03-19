using System.Collections;
using System.Collections.Generic;
using Assets.Code.Input;
using UnityEngine;
using UnityEngine.Networking;

namespace Assets.Code.Player
{
    public class PlayerEntity : NetworkBehaviour
    {
        public GameObject AvatarPrefab;

        private GameObject avatar;

        void Start()
        {
            CmdSpawnAvatar();
        }

        [Command]
        void CmdSpawnAvatar()
        {
            var go = Instantiate(AvatarPrefab, Vector3.zero, Quaternion.identity);
            avatar = go;

            NetworkServer.SpawnWithClientAuthority(go, connectionToClient);
        }
    }
}
