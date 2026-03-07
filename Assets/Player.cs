using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public GameObject fireballPrefab;
    public Transform attackPoint;
    public int coins;

    //Обьект, отвечающий за проигрывание звука
    public AudioSource audioSource;

    //Звуковой файл, содержащий звук урона
    public AudioClip damageSound;


    //Здоровье игрока
    private int health = 10;

    //Метод понижающий здоровье игрока
    public void TakeDamage(int damage) {
        health -= damage;
        if(health > 0)
        {
            audioSource.PlayOneShot(damageSound);
        }
        else
        {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }
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


    //Метод для сбора монет
    public void CollectCoins()
    {
        coins += 1;
        print("Количество монет" + coins);
    }


    
}
