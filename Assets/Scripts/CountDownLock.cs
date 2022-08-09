using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CountDownLock : MonoBehaviour
{
    float currTime = 0f;
    float startingTime = 60;
    string lockName;
    bool lockValue;
    [SerializeField] Text countDownText;
    // Start is called before the first frame update
    void Start()
    {
        lockName = gameObject.name;

            switch (lockName)
            {
                case "lockGame1":
                    lockValue = GameManager.boolgame1Lock;
                    break;
                case "lockGame2":
                    lockValue = GameManager.boolgame2Lock;
                    break;

            }
        
        currTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.FloorToInt(currTime) == 0f)
        {  
            currTime = 60f;
            Debug.Log("Lock done");

                switch (lockName)
                {
                    case "lockGame1":
                        GameManager.Game1LockPanel.SetActive(false);
                        GameManager.boolgame1Lock = false;
                        break;
                    case "lockGame2":
                        GameManager.Game2LockPanel.SetActive(false);
                        GameManager.boolgame2Lock = false;
                        break;
                    case "lockGame3":
                        GameManager.Game3LockPanel.SetActive(false);
                        GameManager.boolgame3Lock = false;
                        break;
                }
            
        }
        currTime -= 1 * Time.deltaTime;
        float second = Mathf.FloorToInt(currTime % 60);
        countDownText.text = second.ToString("00");
       // Debug.Log(Mathf.FloorToInt(currTime));
        
    }
}
