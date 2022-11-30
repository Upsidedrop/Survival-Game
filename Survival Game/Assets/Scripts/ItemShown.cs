
using UnityEngine;

public class ItemShown : MonoBehaviour
{
    public GameObject axe;
    public GameObject pickaxe;
    public GameObject Smallrock;
    public GameObject log;
    public int[] items;
    SelectedItem SelectedItem;

    void Start()
    {

        SelectedItem = GetComponent<SelectedItem>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (items[Mathf.Clamp(SelectedItem.selected, 0, 8)])
        {
            case 1:
                axe.SetActive(true);
                pickaxe.SetActive(false);
                Smallrock.SetActive(false);
                log.SetActive(false);
                break;
            case 2:
                pickaxe.SetActive(true);
                axe.SetActive(false);
                Smallrock.SetActive(false);
                log.SetActive(false);

                break;
            case 3:
                pickaxe.SetActive(false);
                axe.SetActive(false);
                Smallrock.SetActive(true);
                log.SetActive(false);

                break;
            case 4:
                pickaxe.SetActive(false);
                axe.SetActive(false);
                Smallrock.SetActive(false);
                log.SetActive(true);

                break;
            default:
                axe.SetActive(false);
                pickaxe.SetActive(false);
                Smallrock.SetActive(false);
                log.SetActive(false);
                break;
        }
        
    }
}
