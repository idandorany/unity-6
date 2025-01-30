using UnityEngine;

public class BlendTree2DController : MonoBehaviour
{
    public Animator animator;

    void Update()
    {
        float speed = Input.GetAxis("Vertical");
        float direction = Input.GetAxis("Horizontal");

        animator.SetFloat("Speed", speed);
        animator.SetFloat("Direction", direction);
    }
}
