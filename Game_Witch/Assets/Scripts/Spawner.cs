using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    [SerializeField] GameObject Object;

    public float minSpawnRate = 0f;
    public float maxSpawnRate = 2f;
    public float minHeight = 0f;
    public float maxHeight = 0f;
    GameObject pipes;

    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn), Random.Range(minSpawnRate, maxSpawnRate), Random.Range(minSpawnRate, maxSpawnRate));
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }

    public void Spawn()
    {
        pipes = Instantiate(prefab, transform.position, Quaternion.identity, Object.transform);
        pipes.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
    }
}
