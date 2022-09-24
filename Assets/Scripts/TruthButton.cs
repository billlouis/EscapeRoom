using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TruthButton : MonoBehaviour
{
    int button1, button2, button3, button4;
    public Sprite pattern1, pattern2, pattern3, pattern4, pattern5, pattern6, pattern7, pattern8;
    Sprite[] pat = new Sprite[8];
    public GameObject box1, box2, box3, box4;
    public GameObject panel;
    void Start()
    {
        button1 = button2 = button3 = button4 = 1;
        box1.GetComponent<Image>().sprite = pattern1;
        box2.GetComponent<Image>().sprite = pattern1;
        box3.GetComponent<Image>().sprite = pattern1;
        box4.GetComponent<Image>().sprite = pattern1;
        pat[0] = pattern1; pat[1] = pattern2; pat[2] = pattern3; pat[3] = pattern4; 
        pat[4] = pattern5; pat[5] = pattern6; pat[6] = pattern7; pat[7] = pattern8;
    }

    public void confirmButton()
    {
        Debug.Log("truth = " + button1 + "" +button2 + "" + button3 + "" +button4);
        if (button1 == 1 && button2 == 2 && button3 == 3 && button4 == 4)
        {
            PanelWin.PanelMenang(GameManager.gameWinState.game5Menang);
            GameManager.boolgame5Menang = true;
            panel.SetActive(false);
            GameManager.AdaPanel = false;
        }
        else
        {
            PanelWin.PanelLock(GameManager.gameLockState.game5Lock);
            GameManager.boolgame5Lock = true;
            panel.SetActive(false);
            GameManager.AdaPanel = false;
        }
    }
    public void buttonUp(int digit)
    {
        Debug.Log("truth = " + button1 + "" + button2 + "" + button3 + "" + button4);
        switch (digit)
        {
            case 1:
                if (button1 == 8) { button1 = 1;
                    box1.GetComponent<Image>().sprite = pattern1;
                }
                else { button1++; box1.GetComponent<Image>().sprite = pat[button1-1]; }
                break;
            case 2:
                if (button2 == 8){ button2 = 1;
                    box2.GetComponent<Image>().sprite = pattern1;
                }
                else { button2++; box2.GetComponent<Image>().sprite = pat[button2-1]; }
                break;
            case 3:
                if (button3 == 8){ button3 = 1;
                    box3.GetComponent<Image>().sprite = pattern1;
                }
                else { button3++; box3.GetComponent<Image>().sprite = pat[button3-1]; }
                break;
            case 4:
                if (button4 == 8) {button4 = 1;
                    box4.GetComponent<Image>().sprite = pattern1;
                }
                else { button4++; box4.GetComponent<Image>().sprite = pat[button4-1]; }
                break;
        }
    }
    public void buttonDown(int digit)
    {
        Debug.Log("truth = " + button1 + "" + button2 + "" + button3 + "" + button4);
        switch (digit)
        {
            case 1:
                if (button1 == 1)
                {
                    button1 = 8;
                    box1.GetComponent<Image>().sprite = pattern4;
                }
                else { button1--; box1.GetComponent<Image>().sprite = pat[button1-1]; }
                break;
            case 2:
                if (button2 == 1)
                {
                    button2 = 8;
                    box2.GetComponent<Image>().sprite = pattern4;
                }
                else { button2--; box2.GetComponent<Image>().sprite = pat[button2-1]; }
                break;
            case 3:
                if (button3 == 1)
                {
                    button3 = 8;
                    box3.GetComponent<Image>().sprite = pattern4;
                }
                else { button3--; box3.GetComponent<Image>().sprite = pat[button3-1]; }
                break;
            case 4:
                if (button4 == 1)
                {
                    button4 = 8;
                    box4.GetComponent<Image>().sprite = pattern4;
                }
                else { button4--; box4.GetComponent<Image>().sprite = pat[button4-1]; }
                break;

        }
    }
}
