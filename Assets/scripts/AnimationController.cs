using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator animator;

    void Update()
    {
        float speed = Input.GetAxis("Vertical");
        animator.SetFloat("Speed", speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Jump");
        }

        if (speed > 0)
        {
            animator.SetBool("IsRunning", true);
        }
        else
        {
            animator.SetBool("IsRunning", false);
        }
    }
}
