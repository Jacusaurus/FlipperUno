using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewGameButton()
	{
        SceneManager.LoadScene("Table");
        //run configure
        // initi ame stuff in all that
	}

    public void RulesButton()
	{
        SceneManager.LoadScene("Rules");
	}

    public void SettingsButton()
	{
        SceneManager.LoadScene("Settings");
	}

    public void QuitButton()
	{
        Application.Quit();
	}
}
