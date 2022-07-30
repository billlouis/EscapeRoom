using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpen : MonoBehaviour
{

    public GameObject panel;
    public void OpenPanel()
    {
        if (panel != null && !GameManager.AdaPanel)
        {
            panel.SetActive(true);
            GameManager.AdaPanel = true;
        }
    }
    public void ClosePanel()
    {
        if (GameManager.AdaPanel)
        {
            panel.SetActive(false);
            GameManager.AdaPanel = false;
        }
    }
}
