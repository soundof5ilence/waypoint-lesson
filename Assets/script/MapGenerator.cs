using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{

    int[,] map =
    {
        {0,1,0,0,0,0 },
        {0,1,0,0,0,0 },
        {0,1,1,1,1,1 },
        {0,0,0,0,0,1 },
        {0,0,0,0,0,1 },
        {0,0,0,0,0,2 }
    };
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < map.GetLength(0); i ++)
        {
            for(int j = 0; j < map.GetLength(1); j++)
            {
                GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Plane);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
