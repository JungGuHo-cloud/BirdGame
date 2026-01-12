using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public TextMeshProUGUI scoreLabel;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // score 점수 호출, 디폴트 값으로 0
        int score = PlayerPrefs.GetInt("Score", 0);
        if (score > 9999) 
        {
            score = 9999;
        }
        scoreLabel.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayAgainPressed()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void QutiPressed() 
    {
        Application.Quit();
    }
}
