using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class ButtonLoadSCene : MonoBehaviour
{

    public string NameOfSceneToLoad;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	void Awake()
	{
        SceneManager.LoadScene(NameOfSceneToLoad);
	}
}
