using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] Transform target;

    void LateUpdate() //Called after all other updates are called, used to prevent camera jump bug. Check unity execution order for more details.
    {
        transform.position = target.position;
    }
}
