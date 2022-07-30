using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jam : MonoBehaviour
{

    private Transform menitHandTransform;
    private Transform jamHandTransform;
    public static float rotasiMenit;
    public static float rotasiJam;
    // Start is called before the first frame update
    void Awake()
    {
        menitHandTransform = transform.Find("MenitHand");
        jamHandTransform = transform.Find("JamHand");
        rotasiMenit = 0f;
        rotasiJam = 0f;
    }

    void Update()
    {
        menitHandTransform.eulerAngles = new Vector3(0, 0, rotasiMenit);
        jamHandTransform.eulerAngles = new Vector3(0, 0, rotasiJam);
    }


}
