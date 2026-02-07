using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float speed=0;
    public Transform target;
    public int playerDamage = 2; 

    void Update()
    {
        //ћен€ет каждый кадр позиции NPC на новую

        transform.position =
    Vector3.MoveTowards(transform.position,
    target.position, speed + Time.deltaTime);

        //–азворачивает каждый кадр NPC лицом к цели
        transform.LookAt(target.position);
    }
    
}
