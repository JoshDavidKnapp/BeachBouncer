using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public GameObject mainMenuPanel;

    public GameObject example;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        mainMenuPanel.SetActive(false);
    }

    public void Store()
    {

    }

    public void HighScores()
    {

    }

    public void Quit()
    {
        Application.Quit();
    }

    public void ExampleClose()
    {
        example.SetActive(false);

    }

    public void ExampleOpen()
    {
        example.SetActive(true);
    }
}
