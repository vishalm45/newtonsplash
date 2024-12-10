using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score = 0;

    public void AddPoints(int points)
    {
        Debug.Log("ScoreText assigned: " + (scoreText != null));
        score += points;
        Debug.Log($"score updated {score}"); //log updated score
        UpdateScoreDisplay();
    }

    private void UpdateScoreDisplay()
    {
        Debug.Log("updating score display");
        scoreText.text = $"Score: {score}";
    }
}
