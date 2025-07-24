using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 40.0f;
    private float zleft=-12.0f;//left movent limit
    private float zright = 32.0f;//right movement limit

    public GameObject food;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { //player moves left and right
        float moveright = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right *moveright* speed * Time.deltaTime);

        //player movement limit
        if (transform.position.z < zleft)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zleft);

        }
        if (transform.position.z >zright)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zright);

        }
        //when player shoots
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(food, transform.position, food.transform.rotation);
        }
    }
}
