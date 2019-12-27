using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using UnityEditor.Animations;

public class Mover : MonoBehaviour
{

    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            MoveToCursor();
        }
        UpdateAnimator();
    }

    private void MoveToCursor()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit; //Unassigned variable that we will use to store: "OUT" raycastHit data, in the next line ->
        bool hasHit = Physics.Raycast(ray,out hit);
        if(hasHit)
        {
            GetComponent<NavMeshAgent>().destination = hit.point;
        }
    }

    void UpdateAnimator()
    {
        Vector3 velocity = GetComponent<NavMeshAgent>().velocity;
        Vector3 localVelocity = transform.InverseTransformDirection(velocity);
        GetComponent<Animator>().SetFloat("forwardSpeed", localVelocity.z);
    }
}