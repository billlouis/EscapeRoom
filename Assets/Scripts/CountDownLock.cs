using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CountDownLock : MonoBehaviour
{
    float currTime = 0f;
    float startingTime = 60f;
    string lockName;
    [SerializeField] Text countDownText;
    // Start is called before the first frame update
    void Start()
    {
        lockName = gameObject.name;    
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
                    case "lockGame01":
                        GameManager.Game1LockPanel.SetActive(false);
                        GameManager.boolgame1Lock = false;
                        break;
                    case "lockGame02":
                        GameManager.Game2LockPanel.SetActive(false);
                        GameManager.boolgame2Lock = false;
                        break;
                    case "lockGame03":
                        GameManager.Game3LockPanel.SetActive(false);
                        GameManager.boolgame3Lock = false;
                        break;
                    case "lockGame04":
                    CableCutGame.redcable.GetComponent<CableCode>().ResetButtonImage();
                    CableCutGame.yellowcable.GetComponent<CableCode>().ResetButtonImage();
                    CableCutGame.greencable.GetComponent<CableCode>().ResetButtonImage();
                    CableCutGame.bluecable.GetComponent<CableCode>().ResetButtonImage();
                    CableCutGame.greycable.GetComponent<CableCode>().ResetButtonImage();
                    GameManager.Game4LockPanel.SetActive(false);
                        GameManager.boolgame4Lock = false;
                        break;
                    case "lockGame05":
                        GameManager.Game5LockPanel.SetActive(false);
                        GameManager.boolgame5Lock = false;
                        break;
                }
            
        }
        currTime -= 1 * Time.deltaTime;
        float second = Mathf.FloorToInt(currTime % 60);
        countDownText.text = second.ToString("00");
       // Debug.Log(Mathf.FloorToInt(currTime));
        
    }
}
