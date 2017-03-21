using UnityEngine;
using System.Collections;

public class SpawnPlatform : MonoBehaviour
{

    // How long our level is.
    public int maxPlatforms = 20;
    // The actual game object
    public GameObject platform;
    public GameObject coin1;
    public GameObject coin2;
    // Range of positions where we will spawn a new platform
    public float horizontalMin = 8f;
    public float horizontalMax = 12f;
    public float verticalMin = -3f;
    public float verticalMax = 3f;
    // Where our initial offset is.
    private Vector2 originPosition;

    // Use this for initialization
    void Start()
    {
        originPosition = transform.position;
        Spawn();
    }

    // Function that generates a new gameobject.
    void Spawn()
    {
        int x = 0;
        for (int i = 0; i < maxPlatforms; i++)
        {
            Vector2 randomPosition = originPosition + new Vector2(Random.Range(horizontalMin, horizontalMax), Random.Range(verticalMin, verticalMax));
            Instantiate(platform, randomPosition, Quaternion.identity);
            System.Random rng = new System.Random(System.DateTime.UtcNow.Millisecond);
            x = rng.Next(12);
            if (x < 9)
                Instantiate(coin1, randomPosition + new Vector2(0.0f, 2.0f), Quaternion.identity);
            else
                Instantiate(coin2, randomPosition + new Vector2(0.0f, 2.0f), Quaternion.identity);
            originPosition = randomPosition;
        }
    }


}
