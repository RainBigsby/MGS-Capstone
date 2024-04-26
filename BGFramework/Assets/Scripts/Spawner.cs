using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    public GameObject spawnPrefab;

    [SerializeField]
    public float spawnInterval;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawn(spawnInterval, spawnPrefab));
    }


    private IEnumerator spawn(float interval, GameObject spawnObject)
    {
        yield return new WaitForSeconds(interval);
        GameObject newObject = Instantiate(spawnObject,
            new Vector3(Random.Range(-5f, 5), 5, 0), Quaternion.identity);
        StartCoroutine(spawn(interval, spawnObject));
    }
}
