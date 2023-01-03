using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{

    Timer spawnTimer;

    [SerializeField]
    List<GameObject> spawnPrefabList = new List<GameObject>(3);

    float spawnTime = 1;
    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = gameObject.AddComponent<Timer>();

        spawnTimer.Duration = spawnTime;
        spawnTimer.Run();
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnTimer.Finished)
        {
            Instantiate<GameObject>(spawnPrefabList[Random.Range(0,3)]);

            spawnTimer.Duration = spawnTime;
            spawnTimer.Run();
        }
    }
}
