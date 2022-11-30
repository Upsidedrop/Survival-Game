using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBreak : MonoBehaviour
{
    [HideInInspector]
    public int breaklevel = 3;
    [SerializeField]
    GameObject Drop;
    [SerializeField]
    float dropHeight;
    [SerializeField]
    int dropNumber;
    // Update is called once per frame
    void Update()
    {
        if (breaklevel <= 0)
        {
            for (int i = 0; i < dropNumber; i++)
            {
                Instantiate(Drop, new Vector3(transform.position.x, dropHeight, transform.position.z), Quaternion.Euler(Random.Range(0, 360), -48.927f, Random.Range(0, 360)));       

            }
            Destroy(transform.gameObject);
            
        } 
    }
}
