using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public float reload = 0.5f;
    public bool isReadyShoot = true;
    public GameObject bulletPrefab;

    // Update is called once per frame
    void Update()
    {
        if (isReadyShoot == true)
        {
            GameObject newBullet = Instantiate(bulletPrefab);
            newBullet.transform.position = transform.position;
            newBullet.transform.rotation = transform.rotation;
            isReadyShoot = false;
            StartCoroutine(ReloadGun());
        }
    }
    IEnumerator ReloadGun()
    {
        yield return new WaitForSeconds(reload);
        isReadyShoot = true;
    }
}
