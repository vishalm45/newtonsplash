using UnityEngine;

public class swipeThrower : MonoBehaviour
{
    public GameObject applePrefab;
    public float throwForceMultiplier = 10f;
    public Transform throwPoint; //where apples are spawned
    public ScoreManager scoreManager; //score manager

    private Vector2 startTouchPosition;
    private Vector2 endTouchPosition;

    // Update is called once per frame
    void Update()
    {
        Debug.Log("swipeThrower Update is running");
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Swipe started");
            startTouchPosition = Input.mousePosition;
        }

        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("Swipe ended");
            endTouchPosition = Input.mousePosition;
            ThrowApple();
        }
    }


    void ThrowApple()
    {
        Debug.Log("ThrowApple() called"); // Log the method call

        // Check if the Apple Prefab and Throw Point are assigned
        if (applePrefab == null || throwPoint == null)
        {
            Debug.LogError("ApplePrefab or ThrowPoint is not assigned!");
            return;
        }

        // Instantiate the apple at the ThrowPoint position
        GameObject apple = Instantiate(applePrefab, throwPoint.position, Quaternion.identity);
        Debug.Log("Apple instantiated at: " + throwPoint.position);


        if (apple.activeInHierarchy)
        {
            Debug.Log("Apple is active in the scene.");
        }
        else
        {
            Debug.LogError("Apple is instantiated but not visible. Check layer settings or prefab setup.");
        }

        // Check if the apple prefab has a Rigidbody component
        Rigidbody rb = apple.GetComponent<Rigidbody>();
        if (rb == null)
        {
            Debug.LogError("Rigidbody missing on ApplePrefab!");
            return;
        }

        // Calculate swipe direction
        Vector2 swipeDirection = endTouchPosition - startTouchPosition;

        // Ensure the swipe is upwards to qualify as a throw
        if (swipeDirection.y <= 0)
        {
            Debug.Log("Swipe not upward enough to throw.");
            return;
        }

        // Calculate the throw force based on the swipe direction magnitude
        Vector3 throwDirection = transform.forward + Vector3.up * 0.5f; // Slightly upwards
        float throwForce = swipeDirection.magnitude * throwForceMultiplier;

        // Apply the force to the Rigidbody
        rb.AddForce(throwDirection.normalized * throwForce, ForceMode.Impulse);
        Debug.Log($"Force applied to apple: {throwDirection.normalized * throwForce}");

        // Update the score
        if (scoreManager != null)
        {
            scoreManager.AddPoints(1); // Add 1 point per throw
            Debug.Log("Score updated through ScoreManager.");
        }
        else
        {
            Debug.LogError("ScoreManager is not assigned!");
        }
    }

}
