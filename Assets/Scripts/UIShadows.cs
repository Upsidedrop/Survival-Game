using UnityEngine;

public class UIShadows : MonoBehaviour
{
    public Transform playerTransform;
    // Update is called once per frame
    void Update()
    {
        transform.rotation = playerTransform.rotation;
    }
}
