using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputPath : MonoBehaviour
{
    Camera maincam;
    RaycastHit hitInfo;
    public Transform wallfab;
    public Transform slowE;
    public Transform fastE;



    // Start is called before the first frame update
    void Awake()
    {
        maincam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = maincam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hitInfo, Mathf.Infinity))
            {

                ICommand command = new WallCommand(hitInfo.point, wallfab);


                CommandInvoker.AddCommand(command);
            }
        }
    }
}
