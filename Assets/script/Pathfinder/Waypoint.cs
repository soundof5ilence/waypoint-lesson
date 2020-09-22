﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pathfinder
{
    /// <summary>
    /// De waypoint class beheerd een punt in de wereld. Welke je kunt opvragen
    /// Voor de opdracht is deze class al klaar en hoeft hier niets te gebeuren.
    /// </summary>
    public class Waypoint : MonoBehaviour
    {
        public Vector3 Position { get { return transform.position; } }
    }
}