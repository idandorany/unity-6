using UnityEngine;
using UnityEngine.AI;

public class MoveDestination : MonoBehaviour
{
    public Transform Goal; // The target the agent moves towards
    [SerializeField] private NavMeshAgent _agent;
    [SerializeField] private string _areaName = "Mud"; // Name of the area to avoid
    [SerializeField] private float _areaCost = 50.0f; // High cost to make the area undesirable
    [SerializeField] private Animator _animator;
    void Start()
    {
        if (_agent == null)
        {
            _agent = GetComponent<NavMeshAgent>();
        }

        // Retrieve the area index from the area name
        int areaIndex = NavMesh.GetAreaFromName(_areaName);

        // Set the area cost dynamically
        if (areaIndex >= 0)
        {
            NavMesh.SetAreaCost(areaIndex, _areaCost);
        }
        else
        {
            Debug.LogWarning($"Area '{_areaName}' not found in NavMesh!");
        }

        // Set the agent's destination
        if (Goal != null)
        {
            _agent.SetDestination(Goal.position);
            _animator.SetFloat("Speed", _agent.speed);
        }
        else
        {
            Debug.LogWarning("Goal not set for NavMeshAgent!");
        }
    }
}