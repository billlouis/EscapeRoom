using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool AdaPanel;
    public AudioClip beep;
    private AudioSource audios;
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

    public static GameObject Game1MenangPanel, Game1LockPanel, Game2MenangPanel, Game2LockPanel, 
        Game3MenangPanel, Game3LockPanel, Game4MenangPanel, Game4LockPanel, Game5MenangPanel, Game5LockPanel;
    void Start()
    {
        audios = GetComponent<AudioSource>();
        audios.clip = beep;
        audios.loop = true;
        audios.Play();
        
        AdaPanel = false;
        Game1MenangPanel = GameObject.Find("ggGame1"); Game1MenangPanel.SetActive(false);
        Game1LockPanel = GameObject.Find("lockGame1"); Game1LockPanel.SetActive(false);
        Game2MenangPanel = GameObject.Find("ggGame2"); Game2MenangPanel.SetActive(false);
        Game2LockPanel = GameObject.Find("lockGame2"); Game2LockPanel.SetActive(false);
        Game3MenangPanel = GameObject.Find("ggGame3"); Game3MenangPanel.SetActive(false);
        Game3LockPanel = GameObject.Find("lockGame3"); Game3LockPanel.SetActive(false);
        Game4MenangPanel = GameObject.Find("ggGame4"); Game4MenangPanel.SetActive(false);
        Game4LockPanel = GameObject.Find("lockGame4"); Game4LockPanel.SetActive(false);
        Game5MenangPanel = GameObject.Find("ggGame5"); Game5MenangPanel.SetActive(false);
        Game5LockPanel = GameObject.Find("lockGame5"); Game5LockPanel.SetActive(false);
    }
    private void Update()
    {
        if(boolgame1Menang && boolgame2Menang && boolgame3Menang && boolgame4Menang && boolgame5Menang)
        {
            SceneLoader.LoadWinScene();
        }
    }
}
