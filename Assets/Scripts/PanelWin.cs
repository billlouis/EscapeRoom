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
        else if(gameWinState == GameManager.gameWinState.game3Menang)
        {
            Debug.Log("Menang game3");
            GameManager.boolgame3Menang = true;
            GameManager.Game3MenangPanel.SetActive(true);
        }
        else if(gameWinState == GameManager.gameWinState.game4Menang)
        {
            Debug.Log("Menang game4");
            GameManager.boolgame4Menang = true;
            GameManager.Game4MenangPanel.SetActive(true);
        }
        else if(gameWinState == GameManager.gameWinState.game5Menang)
        {
            Debug.Log("Menang game5");
            GameManager.boolgame5Menang = true;
            GameManager.Game5MenangPanel.SetActive(true);
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
        else if(kunci == GameManager.gameLockState.game3Lock)
        {
            Debug.Log("Kunci Game3");
            GameManager.boolgame3Lock = true;
            GameManager.Game3LockPanel.SetActive(true);
        }
        else if(kunci == GameManager.gameLockState.game4Lock)
        {
            Debug.Log("Kunci Game4");
            GameManager.boolgame4Lock = true;
            GameManager.Game4LockPanel.SetActive(true);
        }
        else if(kunci == GameManager.gameLockState.game5Lock)
        {
            Debug.Log("Kunci game5");
            GameManager.boolgame5Lock = true;
            GameManager.Game5LockPanel.SetActive(true);
        }
    }
}
