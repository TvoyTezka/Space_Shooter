using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 5f;
    public string tag;

    private void Update()
    {
        transform.Translate(Vector2.up * speed * 0.01f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(tag))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
