using UnityEngine;

public class DynamicObstacle : MonoBehaviour
{
    // Movement parameters
    public float moveDistance = 5f; // Total distance to move left and right
    public float moveSpeed = 2f;    // Speed of movement

    private Vector3 startPosition;
    private bool movingRight = true;

    void Start()
    {
        // Record the initial position
        startPosition = transform.position;
    }

    void Update()
    {
        // Calculate the new position
        float moveOffset = moveSpeed * Time.deltaTime * (movingRight ? 1 : -1);
        transform.position += new Vector3(moveOffset, 0, 0);

        // Check if the obstacle reached the moveDistance limit
        if (movingRight && transform.position.x >= startPosition.x + moveDistance)
        {
            movingRight = false; // Change direction
        }
        else if (!movingRight && transform.position.x <= startPosition.x - moveDistance)
        {
            movingRight = true; // Change direction
        }
    }
}