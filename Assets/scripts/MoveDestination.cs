using UnityEngine;
using UnityEngine.AI;

public class MoveDestination : MonoBehaviour
{

    public Transform goal;

    [SerializeField] NavMeshAgent agent;
    void Start()
    {
       
        agent.SetDestination(goal.position);
    }
}
