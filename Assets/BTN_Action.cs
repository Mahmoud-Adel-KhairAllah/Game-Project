using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class BTN_Action : MonoBehaviour
{
    [SerializeField]
    RectTransform infoPanel;
    [SerializeField]
    RectTransform sittPanel;
    [SerializeField]
    InputField PlayerName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void play()
    {
        string player_name = PlayerName.text;
        PlayerPrefs.SetString("player_name", player_name);
        SceneManager.LoadScene(1);
        Debug.Log("Play");
    }
    public void Quit()
    {
        Application.Quit(0);
        Debug.Log("Quit");
    }
    public void Info()
    {
        infoPanel.gameObject.active = true;
        Debug.Log("Info");
    }
    public void ExitInfo()
    {
        infoPanel.gameObject.active = false;
        Debug.Log("ExitInfo");
    }
    public void Settings()
    {
        sittPanel.gameObject.active = true;
        Debug.Log("Settings");
    }
    public void Settingsexit()
    {
        sittPanel.gameObject.active = false;
        Debug.Log("Settingsexit");
    }
}
