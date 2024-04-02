using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public float speed = 1f;
    public bool isMoving = true;
    //public GameObject finalMenu;
    
    void Update()
    {
        if (isMoving == true)
        {
            transform.Translate(Vector2.down * speed * 0.01f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isMoving = false;
            Debug.Log("Не движется фон");
            //finalMenu.SetActive(true);
        }
    }
}
