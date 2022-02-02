using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBounds = 30;
    public float botBounds = -10;
    void Update()
    {
        //Remove objects out of bounds
        if (transform.position.z > topBounds)
            Destroy(gameObject);
        else if (transform.position.z < botBounds)
        {
            Debug.Log("Game over");
            Destroy(gameObject);
        }
            
    }
    
}
