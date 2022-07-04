using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System.Threading;
public class navegar : MonoBehaviour
{
    // Start is called before the first frame update
    public NavMeshAgent Agent;
    public GameObject bola;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            {
                Agent.SetDestination(hit.point);
                
            }
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            

            Debug.Log("R en navegar");
            Agent.SetDestination(new Vector3(0,0,4));

        }

    }
}
        
        
    
