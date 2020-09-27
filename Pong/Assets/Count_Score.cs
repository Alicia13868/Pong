using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Count_Score : MonoBehaviour
{
    public Text scoreboard;
    public GameObject ball;

    public static bool canAddScore = true;

    private int bat_1_score = 0;
    private int bat_2_score = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (ball.transform.position.x >= 20f && canAddScore)
        {
            canAddScore = false;
            bat_1_score++;
        }
        if (ball.transform.position.x <= -20f && canAddScore)
        {
            canAddScore = false;
            bat_2_score++;
        }

        if (bat_1_score >= 7)
        {
            SceneManager.LoadScene(2);
        }
        if (bat_2_score >= 7)
        {
            SceneManager.LoadScene(3);
        }

        scoreboard.text = bat_1_score.ToString() + " - " + bat_2_score.ToString();
    }
}
