using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wep : MonoBehaviour
{
    public GameObject wep1;
    public GameObject wep2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            wep1.gameObject.SetActive(true);
            wep2.gameObject.SetActive(false);

        }
           else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            wep1.gameObject.SetActive(false);
            wep2.gameObject.SetActive(true);

        }
    }
}
