using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Shepherd : MonoBehaviour
{
    public GameObject panel;
    public GameObject sheep;
    string PassTextValue = "";
    Vector3 sheepP;
    private void Start()
    {
        sheepP = new Vector3(sheep.transform.position.x, sheep.transform.position.y, sheep.transform.position.z);
    } 
    public void AddDigit(string digit)
    {
        PassTextValue += digit;
        switch (digit)
        {
            case "L":
                sheep.transform.position = new Vector3(sheep.transform.position.x - 70, sheep.transform.position.y, sheep.transform.position.z);
                break;
            case "U":
                sheep.transform.position = new Vector3(sheep.transform.position.x, sheep.transform.position.y + 70, sheep.transform.position.z);
                break;
            case "R":
                sheep.transform.position = new Vector3(sheep.transform.position.x + 70, sheep.transform.position.y, sheep.transform.position.z);
                break;
            case "D":
                sheep.transform.position = new Vector3(sheep.transform.position.x, sheep.transform.position.y- 70, sheep.transform.position.z);
                break;

        }
        if (PassTextValue == "DDLLLLUUUURU")
        {
            PanelWin.PanelMenang(GameManager.gameWinState.game3Menang);
            panel.SetActive(false);
            GameManager.AdaPanel = false;
            GameManager.boolgame3Menang = true;
        }
        else if (PassTextValue == "" || PassTextValue == "D" || PassTextValue == "DD" || PassTextValue == "DDL" || PassTextValue == "DDLL" ||
            PassTextValue == "DDLLL" || PassTextValue == "DDLLLL" || PassTextValue == "DDLLLLU" || PassTextValue == "DDLLLLUU" || PassTextValue == "DDLLLLUUU"
            || PassTextValue == "DDLLLLUUU" || PassTextValue == "DDLLLLUUUU" || PassTextValue == "DDLLLLUUUUR") { Debug.Log("lol"); }
        else
        {
            PassTextValue = "";
            panel.SetActive(false);
            GameManager.AdaPanel = false;
            PanelWin.PanelLock(GameManager.gameLockState.game3Lock);
            GameManager.boolgame3Lock = true;
            sheep.transform.position = new Vector3(sheepP.x, sheepP.y, sheepP.z);
        }
        Debug.Log(PassTextValue);
    }
}
