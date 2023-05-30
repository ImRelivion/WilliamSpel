using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class BalloonAmount : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text balloonAmount;
    public static int theScore = 0;
    void Start()
    {
        balloonAmount = GameObject.FindGameObjectWithTag("balloonScore").GetComponent<TMP_Text>();
        print(GameObject.FindGameObjectWithTag("balloonScore"));
        theScore = 0;
    }


    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Player")
        {


            Destroy(this.gameObject);
            theScore++;

            balloonAmount.text = "Balloons: " + theScore;

        }

        if (theScore == 7)
        {

            SceneManager.LoadScene(1);
        }

    }
    void Update()
    {


    }
}
