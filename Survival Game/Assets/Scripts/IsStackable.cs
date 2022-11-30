using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsStackable : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    ItemShown ItemShown;
    [SerializeField]
    int index;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ItemShown.items[index] == 0)
        {

        }
    }
}
