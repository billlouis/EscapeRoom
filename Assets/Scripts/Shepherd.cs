using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Shepherd : MonoBehaviour
{
    public GameObject panel;
    public GameObject sheep;
    string PassTextValue = "";
    void Update()
    {
        if(PassTextValue == "LURDLRDD")
        {
            PanelWin.PanelMenang(GameManager.gameWinState.game3Menang);
            panel.SetActive(false);
            GameManager.AdaPanel = false;
            GameManager.boolgame1Menang = true;
        }
        else if (PassTextValue == "" || PassTextValue == "L" || PassTextValue == "LU" || PassTextValue == "LUR" || PassTextValue == "LURD" ||
            PassTextValue == "LURDL" || PassTextValue == "LURDLR" || PassTextValue == "LURDLRD"){}
        else
        {
            PassTextValue = "";
            panel.SetActive(false);
            GameManager.AdaPanel = false;
            PanelWin.PanelLock(GameManager.gameLockState.game3Lock);
            GameManager.boolgame2Lock = true;
        }
    }
        
    public void AddDigit(string digit)
    {
        PassTextValue += digit;
        switch (digit)
        {
            case "L":
                sheep.transform.position = new Vector3(sheep.transform.position.x - 30, sheep.transform.position.y, sheep.transform.position.z);
                break;
            case "U":
                sheep.transform.position = new Vector3(sheep.transform.position.x, sheep.transform.position.y + 30, sheep.transform.position.z);
                break;
            case "R":
                sheep.transform.position = new Vector3(sheep.transform.position.x + 30, sheep.transform.position.y, sheep.transform.position.z);
                break;
            case "D":
                sheep.transform.position = new Vector3(sheep.transform.position.x, sheep.transform.position.y- 30, sheep.transform.position.z);
                break;

        }
        Debug.Log(PassTextValue);
    }
}
