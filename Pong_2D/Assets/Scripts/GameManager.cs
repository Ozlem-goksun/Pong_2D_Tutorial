using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball Ball;
    public Paddle Player_Paddle;
    public Paddle Computer_Paddle;
    private int Player_Score;
    private int Computer_Score;
    public Text PlayerScore_txt;
    public Text ComputerScore_txt;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerScore()
    {
        Player_Score++;
        this.PlayerScore_txt.text = Player_Score.ToString();
        ResetRound();
    }

    public void ComputerScore()
    {
        Computer_Score++;
        this.ComputerScore_txt.text = Computer_Score.ToString();
        ResetRound();
    }

    private void ResetRound()
    {
        this.Player_Paddle.ResetPosition();
        this.Computer_Paddle.ResetPosition();
        this.Ball.ResetPosition();
        this.Ball.AddStartingForce();
    }
    
}
