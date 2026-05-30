using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnim : MonoBehaviour
{
   public Animator animator;
   int isWalkingHash, IsRunningHash;

    void Start()
    {
        isWalkingHash = Animator.StringToHash("isWalking");
        IsRunningHash = Animator.StringToHash("isRunning");
    }

    void Update()
    {
        bool isRunning = animator.GetBool(IsRunningHash);
        bool isWalking = animator.GetBool(isWalkingHash);
        bool forwardPressed = Input.GetKey("w");
        bool runPressed = Input.GetKey("left shift");

        if(!isWalking && forwardPressed)
        {
            animator.SetBool("isWalking", true);
        }

        if(isWalking && forwardPressed)
        {
            animator.SetBool("isWalking", false);
        }

        if(!isRunning &&(forwardPressed && runPressed))
        {
            animator.SetBool("isRunnig", true);
        }

        if (isRunning && (!forwardPressed || !runPressed))
        {
            animator.SetBool("isRunning", false);
        }
    }
}
