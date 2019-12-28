using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            MoveToCursor();
        }
    }
    
    private void MoveToCursor()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit; //Unassigned variable that we will use to store: "OUT" raycastHit data, in the next line ->
        bool hasHit = Physics.Raycast(ray,out hit);
        if(hasHit)
        {
            GetComponent<Mover>().MoveTo(hit.point);
        }
    }
}
