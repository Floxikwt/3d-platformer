using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
   public Animator button1;
   public Animator toOpen;

   void Start()
   {
    button1.enabled = false;

   }

   private void OnTriggerEnter(Collider other)
   {
    button1.enabled = true;
    toOpen.enabled = true;
   }
}
