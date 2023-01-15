using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LosePanel : MonoBehaviour
{
    [SerializeField] Text recordText;
    [SerializeField] private GameObject pause;
    [SerializeField] private GameObject knpause;
    [SerializeField] private GameObject opsion;

    public AudioClip[] audiosss;
    public AudioSource audioss;
    private void Start()
    {
        int lastRunScore = PlayerPrefs.GetInt("lastRunScore");
        int recordScore = PlayerPrefs.GetInt("recordScore");

        if (lastRunScore > recordScore)
        {
            recordScore = lastRunScore;
            PlayerPrefs.SetInt("recordScore", recordScore);
            recordText.text = recordScore.ToString();
        }
        else
        {
            recordText.text = recordScore.ToString();
        }
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(1);
        NewBehaviourScript.speeds = 1f;
        NewBehaviourScript.speedaster = 3f;
        audioss.clip = audiosss[0];
        audioss.Play();
    }

    public void ToMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
        audioss.clip = audiosss[0];
        audioss.Play();
    }
    public void Pauseon()
    {
        pause.SetActive(true);
        knpause.SetActive(false);
        Time.timeScale = 0;
        audioss.clip = audiosss[0];
        audioss.Play();
    }
    public void Pauseoff()
    {
        pause.SetActive(false);
        knpause.SetActive(true);
        Time.timeScale = 1;
        audioss.clip = audiosss[1];
        audioss.Play();
    }
    public void Opsionon()
    {
        opsion.SetActive(true);
        pause.SetActive(false);
        audioss.clip = audiosss[0];
        audioss.Play();
    }
    public void Opsionoff()
    {
        opsion.SetActive(false);
        pause.SetActive(true);
        audioss.clip = audiosss[1];
        audioss.Play();
    }
}