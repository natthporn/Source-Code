using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public Text scoreText;
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
  {
       if(other.tag == "Guns")
       {
           score++;
           scoreText.text = "SCORE : = " + score;
           Destroy(other.gameObject);
       }

       
   }
}
