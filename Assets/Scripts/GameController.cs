using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    // Game Score
    public int Score;
    //prefix
    //public string ScorePrefix = string.Empty;
    //score text object
    //public Text ScoreText = null;
    //time text object
    //public Text TimeText = null;
    //CounDown
    public float TimeLeft;
    //prefix
    //public string TimePrefix = string.Empty;
    //public GameObject completeLevelUI;
    //public GameObject gameOverUI;
    //Can text object
    //public Text CanText = null;
    //prefix
    //public string CanPrefix = string.Empty;
    //Game over text
    //public Text GameOverText = null;
    public bool gameOver = false;
    //public float restartDelay;
    public void LevelComplete()
    {
    }
    public void LevelFail()
    {
    }
    public static GameController ThisInstance = null;
    //---------------
    void Awake()
    {
        ThisInstance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (TimeLeft <= 0)
        {
            gameOver = true;
        }
    }
    //-----------

}
