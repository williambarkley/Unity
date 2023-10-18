using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.TextCore;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{

    public Text puntitos;
    

    public bool die;

    [SerializeField]public int points = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        actualizar();
        die = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(die==true)
        {
            SceneManager.LoadScene("die");
        }

         actualizar();
        Debug.Log(points);
  
    }

    void actualizar()
    {
        puntitos.text = points.ToString();
    }

   



    
}
