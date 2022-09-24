using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimeUpdate : MonoBehaviour
{
    float timeset = 0f;
    [SerializeField] Text waktuText;
    public void tambah1menit()
    {
        timeset = timeset + 60f;
        CountDownTImer.startingTime = timeset;
        waktuText.text = timeset.ToString();
    }
    public void kurang1menit()
    {
        timeset = timeset - 60f;
        CountDownTImer.startingTime = timeset;
        waktuText.text = timeset.ToString();
    }
    public void default60menit()
    {
        timeset = 3600f;
        CountDownTImer.startingTime = timeset;
        waktuText.text = timeset.ToString();
    }


}
