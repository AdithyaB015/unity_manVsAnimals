using UnityEngine;

public class ObjectRespawn : MonoBehaviour
{
    public GameObject[] animals; // drag 1+ prefabs here
    private float spawnX = -10f;
    private int spawnZ = 33;

    //time to spawn
    private float spawnStart = 1.5f;
    private float spawnInterval = 2f;
    private void Start()
    {
        InvokeRepeating("AnimalsSpawn", spawnStart, spawnInterval);

    }

    void Update()
    {
      
            
       
    }
    void AnimalsSpawn()
    {
        int index = Random.Range(0, animals.Length);
        Vector3 pos = new Vector3(spawnX, 0, Random.Range(-spawnZ, spawnZ));
        Instantiate(animals[index], pos, animals[index].transform.rotation);
    }
}
