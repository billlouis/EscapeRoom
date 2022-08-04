using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelWin : MonoBehaviour
{
    
    static public void PanelMenang(GameManager.gameWinState gameWinState)
    {
        
        if (gameWinState == GameManager.gameWinState.game1Menang)
        {
            Debug.Log("Menang game1");
            GameManager.boolgame1Menang = true;
            GameManager.Game1MenangPanel.SetActive(true);
        }
        else if (gameWinState == GameManager.gameWinState.game2Menang)
        {
            Debug.Log("Menang game2");
            GameManager.boolgame2Menang = true;
            GameManager.Game2MenangPanel.SetActive(true);
        }
    }
    static public void PanelLock(GameManager.gameLockState kunci)
    {
        if(kunci == GameManager.gameLockState.game1Lock)
        {
            Debug.Log("Kunci Game1");
            GameManager.boolgame1Lock = true;
            GameManager.Game1LockPanel.SetActive(true);
        }
        else if(kunci == GameManager.gameLockState.game2Lock)
        {
            Debug.Log("Kunci Game2");
            GameManager.boolgame2Lock = true;
            GameManager.Game2LockPanel.SetActive(true);
        }
    }
}
