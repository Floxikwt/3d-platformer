using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
    public int minutes;
    public float seconds;
    public TextMeshProUGUI timerText;

    //Цикл обновления состовляет примерно 0.01 секунды
    void Update()
    {

        seconds -= Time.deltaTime;

        if (seconds <= 0)
        {
            if (minutes > 0)
            {
                seconds += 59;

                minutes--;
            }
            else
            {
                //Если таймер остановился, перезагружаем текущую сцену
                int sceneIndex = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(sceneIndex);

            }
        }

        //Округляем значние секунд до целых для их вывода на экран
        int roundSeconds = Mathf.RoundToInt(seconds);
        timerText.text = minutes.ToString() + ':' + roundSeconds;

    }
}
