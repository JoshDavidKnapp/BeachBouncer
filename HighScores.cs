using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScores : MonoBehaviour
{

    public ScoreCounter scoreCounters;

    public TMPro.TextMeshProUGUI hs1;
    public TMPro.TextMeshProUGUI hs2;
    public TMPro.TextMeshProUGUI hs3;
    public TMPro.TextMeshProUGUI hs4;
    public TMPro.TextMeshProUGUI hs5;

   
    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {

        PlayerPrefs.GetInt("HighScore1", 1);
        PlayerPrefs.GetInt("HighScore2", 1);
        PlayerPrefs.GetInt("HighScore3", 1);
        PlayerPrefs.GetInt("HighScore4", 1);
        PlayerPrefs.GetInt("HighScore5", 1);

        hs1.text = scoreCounters.highScore1.ToString();

        hs2.text = scoreCounters.highScore2.ToString();

        hs3.text = scoreCounters.highScore3.ToString();

        hs4.text = scoreCounters.highScore4.ToString();

        hs5.text = scoreCounters.highScore5.ToString();

    }
}
