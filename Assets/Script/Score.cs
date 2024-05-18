using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static Score instance;

    [SerializeField] private TextMeshProUGUI currentScore;
    [SerializeField] private TextMeshProUGUI highScore;
    [SerializeField] private HighScoreSO highScoreSO;

    private int score;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        currentScore.text = score.ToString();
        highScore.text = highScoreSO.highScore.ToString();
    }

    public void UpdateHighScore()
    {
        if (score > highScoreSO.highScore)
        {
            highScoreSO.highScore = score;
        }
    }

    public void UpdateScore()
    {
        score++;
        currentScore.text = score.ToString();
    }
}
