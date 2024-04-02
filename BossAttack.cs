using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAttack : MonoBehaviour
{
    public GameObject rotateGun;
    public bool isAttacking = false;

    public GameObject laserPrepare;
    public GameObject laser;

    public GameObject drone;

    private void Update()
    {
        if (isAttacking == false)
        {
            isAttacking = true;
            Attack();
        }
    }

    void Attack()
    {
        int r = Random.Range(1, 4);
        if (r == 1)
        {
            StartCoroutine(AttackRotate());
        }
        if(r == 2)
        {
            StartCoroutine(AttackLaser());
        }
        if (r == 3)
        {
            StartCoroutine(AttackDrones());
        }
    }

    IEnumerator AttackRotate()
    {
        rotateGun.SetActive(true);
        yield return new WaitForSeconds(1);
        rotateGun.SetActive(false);
        yield return new WaitForSeconds(1);
        isAttacking = false;
    }

    IEnumerator AttackLaser()
    {
        laserPrepare.SetActive(true);
        yield return new WaitForSeconds(1);
        laserPrepare.SetActive(false);
        laser.SetActive(true);
        yield return new WaitForSeconds(2);
        laser.SetActive(false);
        yield return new WaitForSeconds(1);
        isAttacking = false;
    }

    IEnumerator AttackDrones()
    {
        drone.SetActive(true);
        yield return new WaitForSeconds(1);
        drone.SetActive(false);
        yield return new WaitForSeconds(1);
        isAttacking = false;
    }
}
