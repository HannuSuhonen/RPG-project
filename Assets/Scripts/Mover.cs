using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Mover : MonoBehaviour
{

    [SerializeField] Transform target;

    void Update()
    {
        GetComponent<NavMeshAgent>().destination = target.position;
    }
}