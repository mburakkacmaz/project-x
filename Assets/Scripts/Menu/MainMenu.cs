using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] Image defaultImg;
    [SerializeField] Sprite day2;
    [SerializeField] Sprite night1;
    [SerializeField] Sprite night2;

    private void Start()
    {
        byte hour = byte.Parse(DateTime.Now.ToString("HH"));
        int random = UnityEngine.Random.Range(0, 2);

        if (hour >= 6 && hour <= 18)
        {
            if (random == 1)
                defaultImg.sprite = day2;
        }
        else
        {
            if(random == 0)
                defaultImg.sprite = night1;
            else
                defaultImg.sprite = night2;
        }
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
