using System.Collections;
using UnityEngine;

public class RotateAndShoot : MonoBehaviour
{
    public float reloadTime = 0.5f; // ����� �����������
    public GameObject bulletPrefab; // ������ �������

    public float rotationSpeed = 3f; // �������� ��������

    private bool isReadyToShoot = true; // ���������� � ��������
    private float currentAngle = 0f; // ������� ���� ��������

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

    // ����� ��� ��������
    private void Shoot()
    {
        Instantiate(bulletPrefab, transform.position, Quaternion.Euler(0, 0, currentAngle)); // ������� ������ � ������� ����� ��������
        currentAngle += 90f; // ����������� ���� �������� �� 90 �������� (0, 90, 180, 270)
        if (currentAngle >= 360f)
            currentAngle = 0f;
    }

    // �������� ��� �����������
    IEnumerator ReloadGun()
    {
        yield return new WaitForSeconds(reloadTime);
        isReadyToShoot = true;
    }
}
