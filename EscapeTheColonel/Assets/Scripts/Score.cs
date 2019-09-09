using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public int score = 0;
    public Text text;
    public MainCharacterScript player;

    // Start is called before the first frame update
    void Start()
    {
        player = player.GetComponent<MainCharacterScript>();

    }

    // Update is called once per frame
    void Update()
    {
        if (!player.gameOver)
        {
            score = score + 1;
            text.text = "Score: " + score;
        }
        else
        {
            getScore();
        }
        
    }
    public int getScore()
    {
       return  score;
    }
    public void updateScore(int s)
    {
        score += s;
    }
}
