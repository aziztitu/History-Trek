using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Azee
{
    public class StaticTools
    {
        public static Vector3 CloneVector3(Vector3 origVector3)
        {
            return new Vector3(origVector3.x, origVector3.y, origVector3.z);
        }
    }
}
