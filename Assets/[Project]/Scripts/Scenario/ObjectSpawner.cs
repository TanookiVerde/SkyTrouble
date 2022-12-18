using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TanookiStudio;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField] List<GameObject> objects;
    [Space(10)]
    [SerializeField] private GlobalFloatVariable difficultyIncreaseTax;
    [SerializeField] private float spawnTimeInterval;
    [Space(10)]
    [SerializeField] private BoxCollider2D boundaries;

    private Coroutine spawnLoop;

    void Start()
    {
        this.spawnLoop = StartCoroutine( ISpawnLoop() );
    }

    private IEnumerator ISpawnLoop()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnTimeInterval * difficultyIncreaseTax.GetValue());

            GameObject randomObject = objects[Random.Range(0, objects.Count)];
            Vector3 randomPosition = new Vector3(
                x : Random.Range(boundaries.bounds.min.x, boundaries.bounds.max.x),
                y : Random.Range(boundaries.bounds.min.y, boundaries.bounds.max.y), 
                z : 0
            );

            var go = Instantiate(randomObject);
            go.transform.position = randomPosition;

        }
    }
}
