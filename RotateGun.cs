using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateGun : MonoBehaviour
{
    public float reload = 0.5f;
    public bool isReadyShoot = true;
    public GameObject bulletPrefab;

    public float rotateSpeed = 3;


    private void OnEnable()
    {
        StartCoroutine(ReloadGun());
    }
    private void Update()
    {
        if (isReadyShoot == true)
        {
            GameObject newBullet = Instantiate(bulletPrefab);
            newBullet.transform.position = transform.position;
            newBullet.transform.rotation = transform.rotation;
            isReadyShoot = false;
            StartCoroutine(ReloadGun());
        }
        transform.Rotate(0, 0, rotateSpeed * 0.1f);

    }

    IEnumerator ReloadGun()
    {
        yield return new WaitForSeconds(reload);
        isReadyShoot=true;
    }
}
