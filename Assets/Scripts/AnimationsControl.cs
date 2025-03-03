using UnityEngine;

public class AnimationsControl : MonoBehaviour
{
    [SerializeField] Animator animator;

    [SerializeField] RbVelocity rbVelocity;

    public bool canRun;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("hill"))
        {
            Debug.Log("Running up that hill");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("hill"))
        {
            Debug.Log("Run out of hills");
        }
    }

    void Update()
    {
        canRun = rbVelocity.moveHorizontal != 0;
        animator.SetBool("canRun", canRun);


        //if (rbVelocity.moveHorizontal != 0)
        //{
        //    canRun = true;
        //    animator.SetBool("canRun", true);
        //}
        //else
        //{
        //    canRun = false;
        //    animator.SetBool("canRun", false);

        //}
    }
}
