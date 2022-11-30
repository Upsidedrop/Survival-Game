using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemNumb : MonoBehaviour
{
    [SerializeField]
    int itemIndex;
    [SerializeField]
    int itemType;
    [SerializeField]
    ItemShown ItemShown;

    // Update is called once per frame
    void Update()
    {
        bool IsActive()
        {
            if (itemType == ItemShown.items[itemIndex])
            {
                return true;
            } else {
                return false;
            }
        }
        transform.gameObject.GetComponent<MeshRenderer>().enabled = IsActive();
    }
}
