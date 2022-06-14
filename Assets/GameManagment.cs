using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagment : MonoBehaviour
{
    public Text textScore;
    public Text textName;
    // Start is called before the first frame update
    void Start()
    {
       string player_name =PlayerPrefs.GetString("player_name", "Enter Name");
        textName.text = "Welcome:" + player_name;
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void updateScore(int value)
    {
        textScore.text = "Score:" + value;
    }
}
