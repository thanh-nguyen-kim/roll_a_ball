using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallFactory : MonoBehaviour
{
    [SerializeField] private GameObject wallPrefab;
    private float timeUtilNextSpawn, wallSpawnRate = 0.5f, startTime;
    private void Start()
    {
        startTime = Time.time;
        StartCoroutine(SpawnLoop());
    }
    private IEnumerator SpawnLoop()
    {
        while (true)
        {
            yield return new WaitForSeconds(timeUtilNextSpawn);
            timeUtilNextSpawn = 1f / wallSpawnRate + Random.Range(-1f, 1f);
            GameObject go = Instantiate(wallPrefab, new Vector3(Random.Range(-0.75f, 0.75f), 2, (Time.time - startTime) * 2), Quaternion.identity);
            Destroy(go, 10);
        }
    }
}
