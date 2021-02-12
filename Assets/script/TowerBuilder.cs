using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBuilder : MonoBehaviour
{
   
     public void SetTower(Vector3 location, GameObject Tower)

    {
        GameObject obj = Instantiate(Tower);

        obj.transform.position = location;
    }
}