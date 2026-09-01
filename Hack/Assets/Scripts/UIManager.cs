using UnityEngine;
using TMPro; 


public class UIManager : MonoBehaviour
{
    public static UIManager Instance {get; private set;}

  [SerializeField] private TextMeshProUGUI scoreText; 
  [SerializeField] private TextMeshProUGUI finalScoreText; 
  [SerializeField] private TextMeshProUGUI highScoreText;
  [SerializeField] private GameObject gameOverPanel;
 
    private void Awake()
    {
      if (Instance == null)
      {
         Instance = this;
      }

      else
      {
        Destroy(gameObject);
      }
     ToggleGameOverUI(false);
 
    }

    public void UpdateScore(int score)
    {
      scoreText.text = $"Score:{score} ";
    }

    public void GameOver(int score, int highScore)
    {
        //Update Score text
        finalScoreText.text = $"Final Score: {score}";
        highScoreText.text = $"High Score: {highScore}";
        // Update High Score text
    }

    public void ToggleGameOverUI(bool flag)
    {
      gameOverPanel.SetActive(flag);
    }
}
