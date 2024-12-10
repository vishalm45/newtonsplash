using UnityEngine;

public class AppleCollision : MonoBehaviour
{
    public GameObject splatterPrefab;
    public AudioClip splatterSound;
    public float splatterDuration = 2f;

    private void OnCollisionEnter(Collision collision)
    {
        //destroy apple on collision
        Destroy(gameObject);
        Debug.Log("apple destroyed");
    }
}
