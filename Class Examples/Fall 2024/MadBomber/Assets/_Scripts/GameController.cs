using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject spawnOrigin;
    public GameObject bombPrefab;
    public float timeInterval;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBomb", 0f, timeInterval);
    }

    

    void SpawnBomb()
    {
        Instantiate(bombPrefab,
            spawnOrigin.transform.position,
            spawnOrigin.transform.rotation);
    }
}
