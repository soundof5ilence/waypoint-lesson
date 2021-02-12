using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerClick : MonoBehaviour
{
    [SerializeField] private Camera camera;
    [SerializeField] private TowerBuilder towerbuilder;
    // Start is called before the first frame update
    public GameObject SingleTargetTower;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {

            RaycastHit hit;
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray,out hit))
            {
                GameObject obj = hit.transform.gameObject;

                if (obj.CompareTag("emptyT"))
                {
                    towerbuilder.SetTower(obj.transform.position, SingleTargetTower);
                }
            }


        }

        //////////////////////////
        ///




       
    }
}
