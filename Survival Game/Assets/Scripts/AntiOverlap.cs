using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiOverlap : MonoBehaviour
{
    public GameObject self;
    private void Awake()
    {
        if (Mathf.Abs(transform.position.x) < 2 && Mathf.Abs(transform.position.z) < 2)
        {
            Destroy(self);
        }
        if (Mathf.Abs(transform.position.x) > 60 || Mathf.Abs(transform.position.z) > 60)
        {
            Destroy(self);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Environment"))
        {
            
            Destroy(self);
        }
        
    }
   
}
