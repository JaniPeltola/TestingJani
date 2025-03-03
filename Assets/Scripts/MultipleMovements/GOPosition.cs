using UnityEngine;

public class GOPosition : MonoBehaviour
{
    [Header("Tarkista gameobjectin vauhti tästä")]
    public float moveHorizontal;
    public float moveVertical;
    Vector3 movement;
    [Tooltip("Pidä arvo yli nollan, muuten ei liiku!")]
    public float movementSpeed;

    void Update()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");
        movement = new Vector3(moveHorizontal, moveVertical);
        transform.position += movementSpeed * movementSpeed * Time.fixedDeltaTime * Time.fixedDeltaTime * movement;
    }
}
