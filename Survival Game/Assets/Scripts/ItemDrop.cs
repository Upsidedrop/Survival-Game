using System.Collections;
using UnityEngine;

public class ItemDrop : MonoBehaviour
{
    [SerializeField]
    SelectedItem SelectedItem;
    [SerializeField]
    ItemShown ItemShown;
    [SerializeField]
    Transform cameraTransform;
    [SerializeField]
    string prefabName;
    bool timer = true;

    private void Awake()
    {
        if (transform.gameObject.name != prefabName)
        {
            GetComponent<Rigidbody>().AddForce(cameraTransform.forward * 2.5f, ForceMode.Impulse);
            Destroy(this);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetAxis("Drop") > 0
            && timer)
        {
            timer = false;
            StartCoroutine(Drop());
            
        }
        IEnumerator Drop()
        {
            if (ItemShown.items[SelectedItem.selected]
        == transform.gameObject.GetComponent<ItemType>().type)
            {
                print("drop");
                Instantiate(
                    transform.gameObject,
                    cameraTransform.position + cameraTransform.forward,
                    Quaternion.Euler(Random.Range(0, 360), -48.927f, Random.Range(0, 360)));
                if (ItemShown.items[SelectedItem.selected] != 0)
                {
                    ItemShown.itemsInStack[SelectedItem.selected]--;
                }
                print(prefabName);
            }
            print("drop key");
            yield return new WaitForSeconds(.25f);
            timer = true;
        }
    }
}
