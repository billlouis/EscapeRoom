using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CableCutGame : MonoBehaviour
{
    public GameObject panel;
    string CableTextValue = ""; 
    static public GameObject redcable, yellowcable, greencable, bluecable, greycable;
    private void Start()
    {
        redcable = GameObject.Find("Red");
        yellowcable = GameObject.Find("Yellow");
        greencable = GameObject.Find("Green");
        bluecable = GameObject.Find("Blue");
        greycable = GameObject.Find("Grey");
    }
    public void AddDigit(string digit)
    {
        
        CableTextValue += digit;
        if (CableTextValue == "KMHBA")
        {
            PanelWin.PanelMenang(GameManager.gameWinState.game4Menang);
            panel.SetActive(false);
            GameManager.AdaPanel = false;
            GameManager.boolgame4Menang = true;
        }
        else if (CableTextValue == "" || CableTextValue == "K" || CableTextValue == "KM" || CableTextValue == "KMH" || CableTextValue == "KMHB") { }
        else
        {
            redcable.GetComponent<CableCode>().ResetButtonImage();
            yellowcable.GetComponent<CableCode>().ResetButtonImage();
            greencable.GetComponent<CableCode>().ResetButtonImage();
            bluecable.GetComponent<CableCode>().ResetButtonImage();
            greycable.GetComponent<CableCode>().ResetButtonImage();
            CableTextValue = "";
            panel.SetActive(false);
            GameManager.AdaPanel = false;
            PanelWin.PanelLock(GameManager.gameLockState.game4Lock);
            GameManager.boolgame4Lock = true;
        }
        Debug.Log(CableTextValue);
    }
}
