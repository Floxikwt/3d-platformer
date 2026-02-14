using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject fireballPrefab;
    public Transform attackPoint;

    //Здоровье игрока
    private int health = 10;

    //Метод понижающий здоровье игрока
    public void TakeDamage(int damage){
        health -= damage;
        print("Здоровье игрока:" + health);

       

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab,
      attackPoint.
      position, attackPoint.
      rotation);
        }
    }
}
