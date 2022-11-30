using System.Collections;
using UnityEngine;

public class RaycastSelector : MonoBehaviour
{
    [HideInInspector]
    public RaycastHit raycastHit;

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out raycastHit, 2))
        {
            print(raycastHit.transform.gameObject.name);
        }

    }
}
