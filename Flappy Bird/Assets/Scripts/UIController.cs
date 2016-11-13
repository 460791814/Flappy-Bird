using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIController : MonoBehaviour {
    public static UIController Instance;
    private GameObject getReady;
    private Text scoreText;

    private GameObject gameResult;
    private Text gameScoreText;
    private Text gameBestText;
	// Use this for initialization
	void Awake () {
        Instance = this;
        getReady = transform.Find("GetReady").gameObject;
        scoreText = transform.Find("Score").GetComponent<Text>();
        gameResult = transform.Find("GameResult").gameObject;
        gameScoreText = transform.Find("GameResult/Score").GetComponent<Text>();
        gameBestText = transform.Find("GameResult/Best").GetComponent<Text>();
        gameResult.SetActive(false);
	}
    /// <summary>
    /// 隐藏getready
    /// </summary>
    public void HideGetReady()
    {
        getReady.SetActive(false);
    
    }
    public void UpdateScore(int score)
    {
        scoreText.text = score.ToString();
    }
    public void ShowResult(int  score)
    {
     
        int oldScore=PlayerPrefs.GetInt("best",0);
        if(score>oldScore){
        PlayerPrefs.SetInt("best",score);
        }
      gameScoreText.text =score.ToString();
      gameBestText.text = PlayerPrefs.GetInt("best", 0).ToString();
      gameResult.SetActive(true);
    }
    public void OnRestart()
    {
        GameController.Instance.onRestart();
    }
}
