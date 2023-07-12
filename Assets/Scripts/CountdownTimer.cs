using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class CountdownTimer : MonoBehaviour
{
    public string LevelToLoad;
    private float timer = 4.36758f;
    private Text timerSeconds;


    // Use this for initialization
    void Start()
    {
        timerSeconds = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        timerSeconds.text = timer.ToString("f2");
        if (timer <= 0)
        {
            Application.LoadLevel(LevelToLoad);
        }

    }
}