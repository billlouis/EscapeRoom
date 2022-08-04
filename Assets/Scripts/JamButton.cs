using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JamButton : MonoBehaviour
{
    public void ButtonMenit()
    {
        if (Jam.rotasiMenit > -330)
        {
            Jam.rotasiMenit -= 30;
        }
        else if (Jam.rotasiMenit == -330)
        {
            Jam.rotasiMenit = 0;
        }
        Debug.Log("MenitHand =" + Jam.rotasiMenit);
    }

    public void ButtonJam()
    {
        if (Jam.rotasiJam > -330)
        {
            Jam.rotasiJam -= 30;
        }
        else if (Jam.rotasiJam == -330)
        {
            Jam.rotasiJam = 0;
        }
        Debug.Log("JamHand =" + Jam.rotasiJam);
    }

    public void ConfirmJam()
    {
        if(Jam.rotasiJam == 0 && Jam.rotasiMenit == -270)
        {
            GameManager.boolgame1Menang = true;
            PanelWin.PanelMenang(GameManager.gameWinState.game1Menang);
        }
        else
        {
            GameManager.boolgame1Lock = true;
            PanelWin.PanelLock(GameManager.gameLockState.game1Lock);
        }
    }
}
