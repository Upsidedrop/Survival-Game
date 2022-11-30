
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    Rigidbody playerRigidbody;
    public Animator axeAnimator;
    public Animator pickaxeAnimator;
    [SerializeField]
    Animator heldItem;
    float rotation = 0;
    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
       
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Vertical") > 0)
        {
            playerRigidbody.velocity = (transform.forward * 10);
        }
        if (Input.GetAxis("Vertical") < 0)
        {
            playerRigidbody.velocity = (transform.forward * -7f);
        }
        
        if (Input.GetAxis("Horizontal") > 0)
        {
            playerRigidbody.velocity = (transform.right * 7f);
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            playerRigidbody.velocity = (transform.right * -7f);
        }
        if (Input.GetAxis("Horizontal") == 0 && Input.GetAxis("Vertical") == 0)
        {
            playerRigidbody.velocity = (Vector3.zero);
        }
        if (Input.GetAxis("Horizontal") > 0 && Input.GetAxis("Vertical") > 0)
        {
            playerRigidbody.velocity = ((transform.forward + transform.right) * 6.5f);
        }
        if (Input.GetAxis("Horizontal") < 0 && Input.GetAxis("Vertical") < 0)
        {
            playerRigidbody.velocity = ((transform.forward + transform.right) * -5f);
        }
        if (Input.GetAxis("Horizontal") < 0 && Input.GetAxis("Vertical") > 0)
        {
            playerRigidbody.velocity = (transform.forward * 6.5f + transform.right * -6.5f);
        }
        if (Input.GetAxis("Horizontal")  > 0 && Input.GetAxis("Vertical") < 0)
        {
            playerRigidbody.velocity = (transform.forward * -5f + transform.right * 5f);
        }
        
        rotation += Input.GetAxis("Mouse X");
        transform.rotation = Quaternion.Euler(0, rotation,0);
        heldItem.SetFloat("speed", Mathf.Abs(Input.GetAxis("Vertical")) + Mathf.Abs(Input.GetAxis("Horizontal")));
        pickaxeAnimator.SetFloat("Left Mouse", Input.GetAxis("Use On"));
        axeAnimator.SetFloat("Left Mouse", Input.GetAxis("Use On"));
    }
}
