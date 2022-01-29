using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBounds = 30;
    public float botBounds = -10;
    void Update()
    {
        if (transform.position.z > topBounds 
            || transform.position.z < botBounds)
            Destroy(gameObject);
    }
    
}
