using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Mover : MonoBehaviour
{
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            MoveToCursor();
        }
    }

    private void MoveToCursor()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit; //Unassigned variable that we will use to store: out hit data, in the next line ->
        bool hasHit = Physics.Raycast(ray,out hit);
        if(hasHit)
        {
            GetComponent<NavMeshAgent>().destination = hit.point;
        }
    }
}