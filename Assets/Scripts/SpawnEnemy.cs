using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{


    public GameObject enemyPrefab;
    public float cooldawnSpawnEnemy = 5f;

    private Transform _selfTransform;
    private Vector3 _position;

    private void Awake()
    {
        _selfTransform = gameObject.GetComponent<Transform>();
        _position = new Vector3(_selfTransform.position.x, _selfTransform.position.y, 0);
    }

    private void Start()
    {
        StartCoroutine(SpawnNewEnemy());
    }

    IEnumerator SpawnNewEnemy()
    {
        while(true)
        {
            Debug.Log("Спавн нового врага");
            Instantiate(enemyPrefab, _position, Quaternion.identity);
            yield return new WaitForSeconds(cooldawnSpawnEnemy);
        }
    }

}
