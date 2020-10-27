using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// hier stond de namespace voor pathfinder

    /// <summary>
    /// De waypoint class beheerd een punt in de wereld. Welke je kunt opvragen
    /// Voor de opdracht is deze class al klaar en hoeft hier niets te gebeuren.
    /// </summary>
    public class Waypoint : MonoBehaviour
    {
        public Vector3 Position { get { return transform.position; } }
    }
