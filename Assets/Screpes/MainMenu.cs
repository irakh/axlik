using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Text coinsText;
    [SerializeField] private GameObject opsion;
    [SerializeField] private GameObject avtor;
    private void Start()
    {
        int coins = PlayerPrefs.GetInt("coins");
        coinsText.text = coins.ToString();
    }
    public AudioClip[] audiosss;
    public AudioSource audioss;

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
        audioss.clip = audiosss[0];
        audioss.Play();
    }

    public void Exitgame()
    {
        Application.Quit();
        audioss.clip = audiosss[0];
        audioss.Play();
    }

    public void Opsionon()
    {
        opsion.SetActive(true);
        audioss.clip = audiosss[0];
        audioss.Play();
    }
    public void Opsionoff()
    {
        opsion.SetActive(false);
        audioss.clip = audiosss[1];
        audioss.Play();
    }
    public void Avtoron()
    {
        avtor.SetActive(true);
        audioss.clip = audiosss[0];
        audioss.Play();
    }
    public void Avtoroff()
    {
        avtor.SetActive(false);
        audioss.clip = audiosss[1];
        audioss.Play();
    }
}