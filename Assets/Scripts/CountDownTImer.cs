using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CountDownTImer : MonoBehaviour
{
    float currTime = 0f;
    float startingTime = 3610;

    [SerializeField] Text countDownText;
    // Start is called before the first frame update
    void Start()
    {
        currTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currTime -= 1 * Time.deltaTime;
        float hour = Mathf.FloorToInt(currTime / 3600);
        float minute = Mathf.FloorToInt((currTime - hour*3600) / 60);
        float second = Mathf.FloorToInt(currTime % 60);
        countDownText.text = hour.ToString("00") + ":" + minute.ToString("00") + ":" + second.ToString("00");
    }
}
