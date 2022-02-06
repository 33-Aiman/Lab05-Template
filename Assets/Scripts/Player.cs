using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Text Scoretext;
    public int score;

    Rigidbody PlayerRigidbody;
    void Start()
    {
        PlayerRigidbody = GetComponent<Rigidbody>();
    }


    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            Debug.Log("Coin has been detected!!!");
            score += 10;
            Scoretext.text = "Score: " + score.ToString();
            Destroy(other.gameObject);
            if (score == 60)
            {
                SceneManager.LoadScene("GameWinScene");
            }
        }

        /*
        if (other.gameObject.tag == "Collectibles")
        {
            score++;
            ScoreText.text = "Score: " + score.ToString();
            Destroy(other.gameObject);
            if (score == 4)
            {
                //SceneManager.LoadScene("MazeGameLevel2");
                SceneManager.LoadScene("GameWin");
            }
        }
        */

    

    }


}
