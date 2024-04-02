using System.Collections;
using UnityEngine;

public class DronesShoot : MonoBehaviour
{
    public float reloadTime = 1.0f; // ����� ����� ����������
    public GameObject bulletPrefab; // ������ �������

    private bool canShoot = true; // ����� �� ������ ��������

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

    // ����� ��� ��������
    void Shoot()
    {
        GameObject newBullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
    }

    // �������� ��� �����������
    IEnumerator ReloadGun()
    {
        yield return new WaitForSeconds(reloadTime);
        canShoot = true;
    }
}
