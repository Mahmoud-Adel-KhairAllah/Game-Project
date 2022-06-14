using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class scoreScript : MonoBehaviour
{
    public Text MyScoreText;
    private int ScoreNum;
    // Start is called before the first frame update
    void Start()
    {
        ScoreNum = 0;
        MyScoreText.text = "Score:" + ScoreNum;
    }
    private void Update()
    {
        if (ScoreNum == 100)
        {
            SceneManager.LoadScene(2);
        }

    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.tag=="mycoin")
        {
            ScoreNum += 1;
            Destroy(collider.gameObject);
        }
        MyScoreText.text = "Score:" + ScoreNum;

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}
