using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text playerScore;
    public Text enemyScore;
    public static Score instancie;
    private void Awake()
    {
        instancie = this;
    }

    public void AddPointToPlayer()
    {
        Player.score++;
        playerScore.text = Player.score.ToString();
    }
    public void AddPointToEnemy()
    {
        Enemy.score++;
        enemyScore.text = Enemy.score.ToString();
    }
}
