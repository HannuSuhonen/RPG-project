using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Combat
{
    public class Fighter : MonoBehaviour
    {

        public void Attack(CombatTarget target)
        {
            print("Aha! Take that!");
            float speed = 100f;
            transform.position = Vector3.MoveTowards(transform.position,target.transform.position, Time.deltaTime * speed);
        }
    }
}
