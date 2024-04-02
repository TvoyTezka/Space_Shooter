using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurrelMove : MonoBehaviour
{
    public float speed = 1f;
    public bool isMoving = true;

    void Update()
    {
        if (isMoving)
        {
            // ���������� Transform.up ��� �������� ����, ���������� �� ���������� �������
            transform.Translate(Vector2.up * speed * 0.01f);
        }
    }
}
