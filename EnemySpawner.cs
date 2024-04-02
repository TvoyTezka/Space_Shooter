using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float reload = 1f;
    public bool isReadyCreate = true;
    public GameObject enemyPrefab;

    private void Update()
    {
        if (isReadyCreate == true)
        {
            GameObject newBullet = Instantiate(enemyPrefab);
            newBullet.transform.position = new Vector3(Random.Range(-9, 9), transform.position.y, 0);
            isReadyCreate = false;
            StartCoroutine(ReloadSpawn());
        }
    }

    IEnumerator ReloadSpawn()
    {
        yield return new WaitForSeconds(reload);
        isReadyCreate = true;
    }
}
