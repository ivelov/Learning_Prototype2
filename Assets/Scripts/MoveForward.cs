using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 40.0f;

    void Update()
    {
        transform.Translate(new Vector3(0,0, Time.deltaTime * speed));
    }
}
