using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fpsCharacterController : MonoBehaviour
{
    // Start is called before the first frame update
    public float m_walkSpeed;

    public int pint;
    
    public CharacterController m_controller;
    public float m_playerCameraRotationSpeed;
    public Vector2 m_playerCameraRotation;
    public int m_playerCameraRotationXLimit;
    public float contador;
    private GameObject muniaux;
    public GameObject wepo1;
    public GameObject wepo2;

    public bool munibool = false;
     CharacterController cc;

     Vector3 currentMovement;

     public float gravity = 9.8f;

     

    public GameObject m_playerCamera;
    void Start()
    {
        m_playerCameraRotation = new Vector2();
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Confined;
         cc = GetComponent<CharacterController>();
         
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = transform.right * Input.GetAxis("Horizontal") + transform.forward *Input.GetAxis("Vertical");
        move *= m_walkSpeed;
        move.y = -9;

        
         
        m_controller.Move(move * Time.deltaTime);
         m_playerCameraRotation.y += Input.GetAxis("Mouse X") * m_playerCameraRotationSpeed;
         m_playerCameraRotation.x += -Input.GetAxis("Mouse Y") * m_playerCameraRotationSpeed;
        m_playerCameraRotation.x = Mathf.Clamp(m_playerCameraRotation.x, -m_playerCameraRotationXLimit,
        m_playerCameraRotationXLimit);
        m_playerCamera.transform.localRotation = Quaternion.Euler(m_playerCameraRotation.x, 0, 0);
        transform.eulerAngles = new Vector2(0, m_playerCameraRotation.y);

         
          if (Input.GetKey("left shift"))
          {
              m_walkSpeed = 15;
          }

          else
               m_walkSpeed = 8; 

      

      

            

            if(munibool == true)
            {
             contador += Time.deltaTime;

               if(contador >= 8.0f)
           {
               muniaux.SetActive(true);
               munibool = false;
               contador = 0;
               
           }
            }
           

        
    }
  
    

    void OnTriggerEnter(Collider other)
    {
      Debug.Log("collision"+other.gameObject.name);
      
      if(other.gameObject.tag.Equals("municion"))
       {
           other.gameObject.SetActive(false);
           if(wepo1.activeSelf)
           GetComponentInChildren<VerySimplePistol>().muni += 20;

           if(wepo2.activeSelf)
           GetComponentInChildren<GunfireController>().muniR += 2;


           
          
         muniaux = other.gameObject;
           munibool = true;

          
  
       }
        
       


    }
    

    

    
}
