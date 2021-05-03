using UnityEngine;

public class Timer : MonoBehaviour
{
    //Maximum time to complete level (in seconds)
    public float MaxTime;
    //Countdown
    [SerializeField]
    private float CountDown = 0;
    // Start is called before the first frame update
    public GameController gameCtr;
    //public GameController gameController;
    void Start()
    {
        CountDown = MaxTime;
    }

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        //Reduce time
        CountDown -= Time.deltaTime;
        gameCtr.TimeLeft = Mathf.Round(CountDown);
    }
}