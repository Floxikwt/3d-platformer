using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int coins;
    public AudioSource audioSource;
    public AudioClip collectSound;
    public AudioClip damageSound;

    public void CollectCoins()

    {
        //Увеличение кол-ва монет на еденицу
        coins++;

        //Воспроизведение звука сбора монет
        audioSource.PlayOneShot(collectSound);

        //Печать информации о собранных монетах
        print(" Собрано монет: " + coins);
    }
}
