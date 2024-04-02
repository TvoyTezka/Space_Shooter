using System.Collections;
using UnityEngine;

public class RotateAndShoot : MonoBehaviour
{
    public float reloadTime = 0.5f; // Время перезарядки
    public GameObject bulletPrefab; // Префаб снаряда

    public float rotationSpeed = 3f; // Скорость вращения

    private bool isReadyToShoot = true; // Готовность к выстрелу
    private float currentAngle = 0f; // Текущий угол поворота

    private void OnEnable()
    {
        StartCoroutine(ReloadGun());
    }

    private void Update()
    {
        if (isReadyToShoot)
        {
            Shoot();
            isReadyToShoot = false;
            StartCoroutine(ReloadGun());
        }
    }

    // Метод для выстрела
    private void Shoot()
    {
        Instantiate(bulletPrefab, transform.position, Quaternion.Euler(0, 0, currentAngle)); // Создаем снаряд с текущим углом поворота
        currentAngle += 90f; // Увеличиваем угол поворота на 90 градусов (0, 90, 180, 270)
        if (currentAngle >= 360f)
            currentAngle = 0f;
    }

    // Корутина для перезарядки
    IEnumerator ReloadGun()
    {
        yield return new WaitForSeconds(reloadTime);
        isReadyToShoot = true;
    }
}
