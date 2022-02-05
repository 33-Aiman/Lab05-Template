using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Coin")
        {
          
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
