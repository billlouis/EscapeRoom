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
    }
}
