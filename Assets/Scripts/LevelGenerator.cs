using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject platformP;

    public int numberofPlatform;
    public float levelWidth = 3f;
    public float minY = 2f;
    public float maxY = 1.5f;


    // Start is called before the first frame update
    void Start()
    {
        Vector3 spawnPosition = new Vector3();

        for(int i = 0; i < numberofPlatform; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x += Random.Range(-levelWidth, levelWidth);
            Instantiate(platformP, spawnPosition, Quaternion.identity);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
