using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreLogic : MonoBehaviour
{

    Text txt;
    public int Score = 0;
    // Start is called before the first frame update
    void Start()
    {
        txt = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        PrintScore();
    }
    public void Addtoscore() {
        Score = Score + 1;
        PrintScore();
    }
    public void PrintScore() {
        txt.text = "Score : " + Score;
    }
}
