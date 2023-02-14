using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text_test_01 : MonoBehaviour
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
        Score.text = "Log" + Log;
    }

    void destination_cafe()
    {
        Log = 13.33;
    }

    void destination_Domi()
    {
        Log = 12.340;
    }
}
