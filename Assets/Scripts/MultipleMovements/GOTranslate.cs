using UnityEngine;

public class GOTranslate : MonoBehaviour
{
    [Header("Tarkista gameobjectin vauhti t�st�")]
    public float moveHorizontal;
    public float moveVertical;
    Vector3 movement;
    [Tooltip("Pid� arvo yli nollan, muuten ei liiku!")]
    public float movementSpeed;

    void Update()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");
        movement = new Vector3(moveHorizontal, moveVertical);
        transform.Translate(movementSpeed * movementSpeed * Time.fixedDeltaTime * Time.fixedDeltaTime * movement);
    }
}
