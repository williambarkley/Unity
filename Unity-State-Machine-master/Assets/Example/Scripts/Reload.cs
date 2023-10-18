using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reload : MonoBehaviour
{   
    [SerializeField] private Animator animator;
    void Start()
    {
        Debug.Log("reload");
        animator.SetTrigger( "Idle" );
    }

}
