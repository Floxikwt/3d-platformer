using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    public float jumpFactor = 2;

    void OnTriggerEnter(Collider other)

    {
        //Крутое видео 
        other.GetComponent<Jump>().jumpStrength *= jumpFactor;
    }

    void OnTriggerExit(Collider other)
    {
        //Фигня
        other.GetComponent<Jump>().jumpStrength /= jumpFactor;

    }
}
