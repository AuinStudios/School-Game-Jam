using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerShoot : MonoBehaviour
{
    
    [SerializeField] private float attackCooldown;
    [SerializeField] private Transform firePoint;
    [SerializeField] private GameObject[] airbullets;
    private float cooldownTimer=Mathf.Infinity;
    public int i;
    private void Update(){
        if(Input.GetKeyDown(KeyCode.Return) && cooldownTimer>attackCooldown)
            Attack();

        cooldownTimer += Time.deltaTime;
    }

    private void Attack(){
        cooldownTimer = 0;
        airbullets[i].transform.position = firePoint.position;
        airbullets[i].GetComponent<airbullet>();
        airbullets[i].SetActive(true);
        if(i==2)
            i=0;
        i++;

    }
}
