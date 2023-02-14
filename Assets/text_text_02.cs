using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text_text_02 : MonoBehaviour
{
    public static double Log;
    public static double Lat;
    private Text Score;
    // Start is called before the first frame update
    void Start()
    {
        Score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Score.text = "Lat" + Lat;
    }

    void destination_cafe()
    {
        Lat = 243.339;
    }


    void destination_Domi()
    {
        Lat = 394.112;
    }
}