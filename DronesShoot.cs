using System.Collections;
using UnityEngine;

public class DronesShoot : MonoBehaviour
{
    public float reloadTime = 1.0f; // Время между выстрелами
    public GameObject bulletPrefab; // Префаб снаряда

    private bool canShoot = true; // Может ли объект стрелять

    void OnEnable()
    {
        StartCoroutine(ReloadGun());
    }

    void Update()
    {
        if (canShoot == true)
        {
            Shoot();
            canShoot = false;
            StartCoroutine(ReloadGun());
        }
    }

    // Метод для стрельбы
    void Shoot()
    {
        GameObject newBullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
    }

    // Корутина для перезарядки
    IEnumerator ReloadGun()
    {
        yield return new WaitForSeconds(reloadTime);
        canShoot = true;
    }
}
