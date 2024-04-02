using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyParticles : MonoBehaviour
{
    public GameObject obj;

    private void OnDestroy()
    {
        obj.transform.parent = null; //Выложить объект с частицами из врага

        obj.SetActive(true); //Включить объект с частицами

        obj.transform.localScale = Vector3.one;
    }
}
