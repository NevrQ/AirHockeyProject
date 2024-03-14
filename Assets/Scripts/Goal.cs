using TMPro;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool Player1Goal = true;
    public TextMeshProUGUI scoreBox;

    public static int player1Score = 0;
    public static int player2Score = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (Player1Goal)
        {
            player2Score++;
        }
        else
        {
            player1Score++;
        }

        scoreBox.text = $"{player1Score} : {player2Score}";
    }

}