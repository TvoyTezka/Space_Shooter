using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float reload = 0.5f;
    public bool isReadyShoot = true;
    public GameObject bulletPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isReadyShoot == true)
        {
            GameObject newBullet = Instantiate(bulletPrefab);
            newBullet.transform.position = transform.position;
            isReadyShoot = false;
            StartCoroutine(ReloadGun());
        }
    }
    IEnumerator ReloadGun()
    {
        yield return new WaitForSeconds(reload);
        isReadyShoot = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("BonusAttackSpeed"))
        {
            reload -= 0.05f;
            Destroy(collision.gameObject);
            if (reload < 0.1f)
            {
                reload = 0.1f;
            }
        }
    }
}
