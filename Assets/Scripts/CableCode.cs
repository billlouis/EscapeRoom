using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CableCode : MonoBehaviour
{
    public Sprite newButtonImage;
    public Sprite originalButtonImage;
    public Button Button;
    public void ChangeButtonImage()
    {
        Button.image.sprite = newButtonImage;
    }
    public void ResetButtonImage()
    {
        Button.image.sprite = originalButtonImage;
    }
}
