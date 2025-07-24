using UnityEngine;

public class BoneShoot : MonoBehaviour
{
    public float speed = 20.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left* speed * Time.deltaTime);
    }
}
