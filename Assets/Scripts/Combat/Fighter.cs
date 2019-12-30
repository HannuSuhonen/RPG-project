using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RPG.Movement;

namespace RPG.Combat
{
    public class Fighter : MonoBehaviour
    {
        Transform target;
        [SerializeField] float weaponRange = 2f;
        private void Update()
        {
            if(target != null)
            {
                GetComponent<Mover>().MoveTo(target.position);
                GetComponent<Mover>().Stop();
            }
        }
        public void Attack(CombatTarget combatTarget)
        {
            target = combatTarget.transform;
        }
    }
}