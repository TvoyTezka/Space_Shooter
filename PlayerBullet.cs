using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public float speed = 5f;

    private void Update()
    {
        transform.Translate(Vector2.up * speed * 0.01f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Boss"))
        {
            HP bossHP = collision.gameObject.GetComponent<HP>();
            bossHP.Damage(1);
            Destroy(gameObject);
        }
    }
}
