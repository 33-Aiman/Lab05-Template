using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private float scorevalue;
    public float totalcoins;
    public float timeleft;
    public float timeRemaining;
   

    public Text Scoretext;
    public Text Timertext;

    
    public float TimerValue ;

    Rigidbody PlayerRigidbody;
    void Start()
    {
        PlayerRigidbody = GetComponent<Rigidbody>();
    }


    void Update()
    {
        timeleft -= Time.deltaTime;
        timeRemaining = Mathf.FloorToInt(timeleft % 60);
        Timertext.text = "Timer: " + timeRemaining.ToString();

        if (scorevalue == 60 && totalcoins == 6)
        {
            if(timeleft <= TimerValue || timeleft >= 0)
            {
                SceneManager.LoadScene("GameWinScene");
            }
        }

        else if (timeleft <= 0)
        {
            SceneManager.LoadScene("GameLoseScene");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            totalcoins++;
            scorevalue += 10;
            Scoretext.text = "Score: " + scorevalue.ToString();
            Destroy(other.gameObject);
           
        }

        if (other.gameObject.tag == "Water")
        {
            
            SceneManager.LoadScene("GameLoseScene");
        }





    }


}
