using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private Animator animator;
   void Start()
    {
        Debug.Log("disparar");
        animator.SetTrigger( "Idle" );
    }
   
}
