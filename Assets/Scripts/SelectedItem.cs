using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedItem : MonoBehaviour
{
    [HideInInspector]
    public int selected = 0;
    // Update is called once per frame
    void Update()
    {
        selected = Mathf.Clamp(selected, 0, 8);
        selected += (int)Mathf.Round(Input.GetAxis("Scroll Wheel"));
        switch (selected)
        {
            case 0:
                transform.localPosition = new Vector2(-368.3f, -231.58f);
                
                break;
            case 1:
                transform.localPosition = new Vector2(-316.3f, -231.58f);
                
                break;
            case 2:
                transform.localPosition = new Vector2(-264.3f, -231.58f);
                
                break;
            case 3:
                transform.localPosition = new Vector2(-211.3f, -231.58f);
                
                break;
            case 4:
                transform.localPosition = new Vector2(-159.3f, -231.58f);

                break;

            case 5:
                transform.localPosition = new Vector2(-107.3f, -231.58f);
            
                break;
            case 6:
                transform.localPosition = new Vector2(-55.7f, -231.58f);
            
                break;
            case 7:
                transform.localPosition = new Vector2(-3.5f, -231.58f);
            
                break;
            case 8:
                transform.localPosition = new Vector2(45.9f, -231.58f);
            
                break;
            default:
                break;
        }

    }
}
