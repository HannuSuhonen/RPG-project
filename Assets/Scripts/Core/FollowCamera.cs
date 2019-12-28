using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;

namespace RPG.Core
{

    public class FollowCamera : MonoBehaviour
    {

        [SerializeField] Transform target;
        [SerializeField] float cameraSpeed = 0;
        Vector3 offset;

        private void Start()
        {
            offset = transform.position - target.position;
        }
        void LateUpdate() //Called after all other updates are called, used to prevent camera jump bug. 
                          //Check unity execution order for more details.
        {
            //transform.position = target.position;
            Vector3 velocity = Vector3.zero;
            transform.position = Vector3.SmoothDamp
            (transform.position, target.position + offset, ref velocity, cameraSpeed);
        }
    }
}
