using UnityEngine;

public class MyStateBehaviour : StateMachineBehaviour
{
    private AudioSource audioSource;

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        audioSource = animator.GetComponent<AudioSource>();

        if (audioSource != null)
        {
   
            if (audioSource.clip != null && audioSource.clip.name == "running")
            {
                audioSource.Play(); 
            }
            else
            {
                Debug.LogWarning("AudioSource does not have the 'running' clip assigned.");
            }
        }
        else
        {
            Debug.LogError("No AudioSource found on the GameObject. Please add one.");
        }
    }

    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (audioSource != null && audioSource.isPlaying)
        {
            audioSource.Stop(); 
        }
    }
}
