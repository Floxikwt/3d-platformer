using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleportPoint;

    void OnTriggerEnter(Collider other)
    {
        //Данные об области игрока(соприкасания с триггером) 
        //other.transform.position = teleportPoint
        
    }
}
