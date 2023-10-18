using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EnemyBehaviour : MonoBehaviour
{
    
    
    public UnityEngine.AI.NavMeshAgent agent { get; private set; }
    private Transform target;

    public Animator eanimation ;

    
    
    

    

    public int vidaE = 7;

    private void Start()
    {
       
        agent = GetComponentInChildren<UnityEngine.AI.NavMeshAgent>();
        agent.updateRotation = true;
        agent.updatePosition = true;
        target = GameObject.FindGameObjectWithTag("Player").transform;
        eanimation.SetBool("dada",true);
        
        
        


        
    }

    private void Update()
    {
           eanimation.SetBool("dada",true);
       
       if(Vector3.Distance(target.position,transform.position) < 15.5f)
       { 
           
           
        if (target != null)
        {
            
            agent.SetDestination(target.position);
            eanimation.SetBool("gonzalo",true);
            
             
            
            if(!agent.pathPending && agent.remainingDistance <7.5f)
            {
                eanimation.SetBool("ATACK",true);
                 if (!agent.pathPending && agent.remainingDistance <1.8f)
                {
                    GetComponentInParent<GameManager>().die = true;
                }


            }
            else 
            { 
                eanimation.SetBool("aa",true);
                eanimation.SetBool("ATACK",false);
            }
            
        }
        else
        {
            if (GameObject.FindGameObjectWithTag("Player") != null)
                target = GameObject.FindGameObjectWithTag("Player").transform;
        }
        eanimation.SetBool("gonzalo",true);
        

        
       }
      
       
        
        

      
       

    }
      void OnCollisionEnter(Collision other)
        {
            if(other.gameObject.tag.Equals("valiza"))
            {
                 vidaE -=10;
                 
                 
            }
        }   
        

    
}