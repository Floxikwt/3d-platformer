using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();

        //Кол-во монет обновляется
        player.CollectCoins();

        //Монета, которую собрали, убирается
        Destroy(gameObject);
    }
}
