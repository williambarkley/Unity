using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class FireGun : MonoBehaviour
{
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = (this.transform.position - gameObject.transform.position).normalized;
        Debug.DrawLine (this.transform.position, pos + dir * 10, Color.red, Mathf.Infinity);
        
    }
}
