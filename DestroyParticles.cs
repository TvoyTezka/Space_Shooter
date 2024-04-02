using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyParticles : MonoBehaviour
{
    public GameObject obj;

    private void OnDestroy()
    {
        obj.transform.parent = null; //�������� ������ � ��������� �� �����

        obj.SetActive(true); //�������� ������ � ���������

        obj.transform.localScale = Vector3.one;
    }
}
