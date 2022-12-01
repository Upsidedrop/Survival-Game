using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    ItemShown ItemShown;
    [SerializeField]
    RaycastSelector RaycastSelector;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Pick Up") > 0
            && RaycastSelector.raycastHit.transform.gameObject.GetComponent<ItemType>() != null)
        {
            for (int i = 0; i < 9; i++)
            {
                
                if (ItemShown.items[i] == RaycastSelector.raycastHit.transform.gameObject.GetComponent<ItemType>().type
                    && ItemShown.itemsInStack[i] < 64)
                {
                    ItemShown.itemsInStack[i] += 1;
                    Destroy(RaycastSelector.raycastHit.transform.gameObject);
                    print(ItemShown.itemsInStack[i]);
                    return;
                }
                
            }
            for (int i = 0; i < 9; i++)
            {
                if (ItemShown.items[i] == 0)
                {
                    ItemShown.items[i] = RaycastSelector.raycastHit.transform.gameObject.GetComponent<ItemType>().type;
                    ItemShown.itemsInStack[i] = 1;
                    Destroy(RaycastSelector.raycastHit.transform.gameObject);
                    return;
                }
            }
        }
    }
}
