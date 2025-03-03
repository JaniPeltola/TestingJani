using UnityEditor.Tilemaps;
using UnityEngine;

public class RbVelocity : MonoBehaviour
{
    [Header("Tarkista gameobjectin vauhti tästä")]
    public float moveHorizontal;
    public float moveVertical;
    Vector3 movement;
    [Tooltip("Pidä arvo yli nollan, muuten ei liiku!")]
    public float movementSpeed;

    [SerializeField] Rigidbody2D rb;

    private void Start()
    {

    }
    void Update()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");
        movement = new Vector2(moveHorizontal, moveVertical);
        rb.linearVelocity = (movementSpeed * movementSpeed * Time.fixedDeltaTime * Time.fixedDeltaTime * movement);

    }
}
