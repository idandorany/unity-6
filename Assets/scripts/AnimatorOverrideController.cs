using System;
using UnityEngine;

public class AnimatorOverrideController : MonoBehaviour
{
    public Animator animator;
    public AnimatorOverrideController overrideController;
    public AnimationClip customIdleAnimation;
    private AnimationClip overrideControllerv;

    void Start()
    {
        animator.runtimeAnimatorController = overrideController;

        overrideControllerv = customIdleAnimation;
    }

    public static implicit operator RuntimeAnimatorController(AnimatorOverrideController v)
    {
        throw new NotImplementedException();
    }
}
