using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory : MonoBehaviour
{
    #region singleton
    public Transform slowE;
    public Transform fastE;
    Camera maincam;
    RaycastHit hitInfo;
    bool spawn;


    //This is the interface used to set up inherited class functions dictating which functions are required
    public interface Enemy
    {
        void Execute(Transform pre, Vector3 position);
    }

    public class FastEnemy : Enemy
    {
        //This is the function from the interface that is need to be overidden based off the class
        public void Execute(Transform pre, Vector3 position)
        {
            //This Creates the actual prefab object 
            Instantiate(pre, position, Quaternion.identity);
        }
    }
    public class SlowEnemy : Enemy
    {
        public void Execute(Transform pre, Vector3 position)
        {
            Instantiate(pre, position, Quaternion.identity);
        }
    }
    private void Awake()
    {
        maincam = Camera.main;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Ray ray = maincam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hitInfo, Mathf.Infinity))
            {
                new SlowEnemy().Execute(slowE, hitInfo.point);
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Ray ray = maincam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hitInfo, Mathf.Infinity))
            {
                new FastEnemy().Execute(fastE, hitInfo.point);
            }
        }
    }
    #endregion

}
