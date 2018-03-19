using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Code.Input
{
    public class MovementInput : MonoBehaviour
    {
        public Vector2 ReadXYAxis
        {
            get { return new Vector2(UnityEngine.Input.GetAxis("Horizontal"), UnityEngine.Input.GetAxis("Vertical")); }
        }
    }
}
