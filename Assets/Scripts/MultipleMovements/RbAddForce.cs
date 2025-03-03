using UnityEngine;

public class RbAddForce : MonoBehaviour
{
    [Header("Tarkista gameobjectin vauhti tästä")]
    public float moveHorizontal;
    public float moveVertical;
    Vector3 movement;
    [Tooltip("Pidä arvo yli nollan, muuten ei liiku!")]
    public float movementSpeed;
    public float jumpForce;
    bool jump;
    Rigidbody2D rb;
    private void Start()
    {

        rb = GetComponent<Rigidbody2D>();

        // rb = gameObject.AddComponent<Rigidbody2D>();


    }



    void Update()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
        //moveVertical = Input.GetAxis("Vertical");
        jump = Input.GetKeyDown(KeyCode.Space);
        movement = new Vector3(moveHorizontal, moveVertical);
        rb.AddForce(movementSpeed * movementSpeed * Time.fixedDeltaTime * Time.fixedDeltaTime * movement);
        if (jump)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}
