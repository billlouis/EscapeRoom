using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PassCode : MonoBehaviour
{
    [SerializeField]
    Text PassText;
    string PassTextValue = "";
    void Update()
    {
        PassText.text = PassTextValue; 
    }
    public void confirm6Digit()
    {
        if (PassTextValue == "314285" || PassTextValue == "314159")
        {
            PanelWin.PanelMenang(GameManager.gameWinState.game2Menang);
            GameManager.boolgame2Menang = true;
        }
        else
        {
            PassTextValue = "";
            PanelWin.PanelLock(GameManager.gameLockState.game2Lock);
            GameManager.boolgame2Lock = true;
        }
    }
    public void AddDigit(string digit)
    {
        if (PassTextValue.Length < 6)
        {
            PassTextValue += digit;
        }
        Debug.Log(PassTextValue);
    }
    public void DeleteDigit()
    {
        if (PassTextValue.Length > 0)
        {
            PassTextValue = PassTextValue.Substring(0, PassTextValue.Length - 1);
        }
    }
}
