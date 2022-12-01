using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StackableText : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    int index;
    TextMeshProUGUI TextMeshProUGUI;
    [SerializeField]
    ItemShown ItemShown;
    void Start()
    {
        TextMeshProUGUI = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        TextMeshProUGUI.text = ItemShown.itemsInStack[index].ToString();
        if (ItemShown.itemsInStack[index] <= 1)
        {
            TextMeshProUGUI.enabled = false;
        }
        else
        {
            TextMeshProUGUI.enabled = true;
        }
    }
}
