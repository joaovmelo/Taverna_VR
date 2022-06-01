using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AboutScript : MonoBehaviour
{
    public GameObject about;
    public double timeLeft = 30.0;
    private bool isShowing;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
        {
            isShowing = !isShowing;
                about.SetActive(isShowing);
            LoadGame();
        }
    }

    public void LoadGame()
    {
        SceneManager.LoadScene(1);
    }
}
