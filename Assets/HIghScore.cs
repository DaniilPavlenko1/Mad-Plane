using UnityEngine;
using UnityEngine.UI;

public class HIghScore : MonoBehaviour
{
    public Text highScore;

    void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    void Update()
    {
        if(Score.score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", Score.score);
            highScore.text = Score.score.ToString();
        }

    }
}
