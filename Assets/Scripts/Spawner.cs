using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject obstacle;
    [SerializeField] Transform spawnPos;
    [SerializeField] float minSeparationTime;
    [SerializeField] float maxSeparationTime;

    // Start is called before the first frame update
    void Awake()
    {
        StartCoroutine(SpawnObstacle());
    }

    private IEnumerator SpawnObstacle()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(minSeparationTime, maxSeparationTime));
            Instantiate(obstacle, spawnPos.position, Quaternion.identity);
        }


    }

}
