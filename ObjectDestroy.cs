using UnityEngine;

public class ObjectDestroy : MonoBehaviour
{
    private float range = 13.0f;//range to destroy the object
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > range)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x < -range)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
        
    }
}
