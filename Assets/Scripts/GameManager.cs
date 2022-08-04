using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool AdaPanel;
    public enum gameWinState
    {
        game1Menang, game2Menang, game3Menang, game4Menang, game5Menang
    }
    public enum gameLockState
    {
        game1Lock, game2Lock, game3Lock, game4Lock, game5Lock
    }

    public static bool 
        boolgame1Menang, boolgame2Menang, boolgame3Menang, boolgame4Menang, boolgame5Menang, 
        boolgame1Lock, boolgame2Lock, boolgame3Lock, boolgame4Lock, boolgame5Lock;

    public static GameObject Game1MenangPanel, Game1LockPanel, Game2MenangPanel, Game2LockPanel;
    void Start()
    {
        AdaPanel = false;
        Game1MenangPanel = GameObject.Find("ggGame1"); Game1MenangPanel.SetActive(false);
        Game1LockPanel = GameObject.Find("lockGame1"); Game1LockPanel.SetActive(false);
        Game2MenangPanel = GameObject.Find("ggGame2"); Game2MenangPanel.SetActive(false);
        Game2LockPanel = GameObject.Find("lockGame2"); Game2LockPanel.SetActive(false);
    }
    void Update()
    {
        
    }
}
