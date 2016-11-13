using UnityEngine;
using System.Collections;

public enum GameStatus
{
  Start,
    Nomal,
    Stop,
    Over
}
public class GameController : MonoBehaviour {
    public static GameController Instance;
    private GameObject player;
    public  GameStatus status = GameStatus.Start;
    private int score;//分数
 
    public GameObject last_bg;
    private Rigidbody playerRigidbody;
    public GameObject getReady;
	// Use this for initialization
	void Awake () {
        Instance = this;
        player = GameObject.FindGameObjectWithTag("Player");
        playerRigidbody = player.GetComponent<Rigidbody>();
        playerRigidbody.isKinematic = true;
	}
	
	// Update is called once per frame
	void Update () {
        switch (status)
        {
            case GameStatus.Start:
                StartGame();
                break;
            case GameStatus.Nomal:

                break;
            case GameStatus.Stop:
                break;
            case GameStatus.Over:
                if (status != GameStatus.Stop) { 
                AudioController.Instance.PlayDie();
                UIController.Instance.ShowResult(score);
                status = GameStatus.Stop;
                }
                break;
            default:
                break;
        }
	}

    private void StartGame()
    {
        if (Input.GetMouseButtonDown(0))
        {
            playerRigidbody.isKinematic = false;
         //   playerRigidbody.velocity = new Vector3(3, 0, 0);
            UIController.Instance.HideGetReady();
           status = GameStatus.Nomal;
            
        }
    }
    public void AddScore()
    {
        score++;
        UIController.Instance.UpdateScore(score);
    }
    public void onRestart()
    {
        Application.LoadLevel(0);
    }
}
