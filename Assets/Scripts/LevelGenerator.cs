using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject platformP;

    public int numberofPlatform;
    public float levelWidth = 3f;
    public float minY = 2f;
    public float maxY = 1.5f;


    //generate random platforms to create a map 
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
}
