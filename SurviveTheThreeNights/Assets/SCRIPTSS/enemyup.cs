using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyup : MonoBehaviour
{
    private bool boli;
    public GameObject en1;
    public float Ty;
    public float vids;
    public int count;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

          if(en1.activeSelf)
        {
      vids =  GetComponentInChildren<EnemyBehaviour>().vidaE;
        }
        vid();
        if(boli==true)
        {
            Ty += Time.deltaTime;
            if(Ty>=3.4f)
            {
                
                en1.SetActive(true); 
                GetComponentInChildren<EnemyBehaviour>().vidaE+=20;
                en1.GetComponent<NavMeshAgent>().speed +=1;
                if(count == 1)
                {
                    GetComponentInChildren<EnemyBehaviour>().vidaE+=30;
                    en1.GetComponent<NavMeshAgent>().speed +=1;
                    
                    
                }
                 if(count == 2)
                {
                    GetComponentInChildren<EnemyBehaviour>().vidaE+=40;
                    en1.GetComponent<NavMeshAgent>().speed +=1;
                }
                 if(count == 3)
                {
                    GetComponentInChildren<EnemyBehaviour>().vidaE+=50;
                    en1.GetComponent<NavMeshAgent>().speed +=2;
                }
                
                
                if(count == 4)
                {
                    Destroy(en1);
                }
                Ty = 0;
                boli=false;
                count++;
                
                
                

            }
        }
       
          
        
        
    }
    public void vid()
        {
            
          if( vids <= 0 && en1.activeSelf)
        {
            en1.SetActive(false);
            
            GetComponentInParent<GameManager>().points+=25;
        
            boli = true;

            
            
        }
        }
}
