using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horisontalInput;
    public float speed = 10;
    public float bounds = 10;
    public GameObject projectilePrefab;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        if (pos.x < -bounds)
        {
            transform.position = new Vector3(-bounds, pos.y, pos.z);
        }
        else if (pos.x > bounds)
        {
            transform.position = new Vector3(bounds, pos.y, pos.z);
        }
        
        horisontalInput = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(horisontalInput * speed * Time.deltaTime,0));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
