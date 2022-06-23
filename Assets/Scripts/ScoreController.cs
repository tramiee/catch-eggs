using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour
{
    public Text scoreText;
    private int score;
    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Bomb")
        {
            GameControl.health -= 1;
            Destroy(collision.gameObject);
        }
        if(collision.tag == "Egg")
        {
            Destroy(collision.gameObject);
            score++;
        }
    }
}
