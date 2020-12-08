using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BallTouchEvent : MonoBehaviour
{
    public Text ScoreT;
    int scoreV=0;
    void OnTriggerEnter(Collider col)
    {
        switch (col.tag)
        {
            case "score10":
                scoreV += 10;
                ScoreT.text = "score" + scoreV;
                break;
            case "score20":
                scoreV += 20;
                ScoreT.text = "score" + scoreV;
                break;
            case "score30":
                scoreV += 30;
                ScoreT.text = "score" + scoreV;
                break;
            case "score40":
                scoreV += 40;
                ScoreT.text = "score" + scoreV;
                break;
            case "reset":
                SceneManager.LoadScene("level1");
                break;
        }
    }
}
