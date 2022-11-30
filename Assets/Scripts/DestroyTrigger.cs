using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTrigger : MonoBehaviour
{
    public RaycastSelector RaycastSelector;
    ObjectBreak ObjectBreak;
    [SerializeField]
    string destructble;
    public void DestroyEvent()
    {
        if (RaycastSelector.raycastHit.transform.gameObject.name == destructble)
        {
        ObjectBreak = RaycastSelector.raycastHit.transform.gameObject.GetComponent<ObjectBreak>();
        RaycastSelector.raycastHit.transform.gameObject.GetComponent<Animator>().SetTrigger("Hit");
        ObjectBreak.breaklevel--;
        }

        
    }
}
