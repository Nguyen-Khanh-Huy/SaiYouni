using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCtrl : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private int State;

    private void Update()
    {
        animator.SetInteger("State", State);
    }
}
