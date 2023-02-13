using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    public static GameManager Instance
    {
        get { return instance; }
    }

    public TMP_Text collectibleCounterText;
    public TMP_Text deathCounterText;
    public TMP_Text timeCounterText;
    public TMP_Text winText;
    public Button retryButton;
    public Button startButton;
    public GameObject levelUI;
    public GameObject startUI;

    private float startTime;
    public float playerSpeed;
    private int deaths;
    private int collectibles;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        startButton.onClick.AddListener(LoadLevelOne);
        retryButton.gameObject.SetActive(false);
        retryButton.onClick.AddListener(ReloadCurrentLevel);
        startUI.SetActive(true);
        levelUI.SetActive(false);
        playerSpeed = 2.0f;
}

    private void Update()
    {
        float elapsedTime = Time.time - startTime;

        timeCounterText.text = "" + elapsedTime.ToString("0.0") + "s";
        deathCounterText.text = "" + deaths;
        collectibleCounterText.text = "" + collectibles;
    }

    public void IncrementDeaths()
    {
        startUI.SetActive(true);
        deaths++;
        retryButton.gameObject.SetActive(true);
        playerSpeed = 2.0f;
    }

    public void IncrementCollectibles()
    {
        collectibles++;
    }

    public int GetDeaths()
    {
        return deaths;
    }

    public int GetCollectibles()
    {
        return collectibles;
    }

    private void LoadLevelOne()
    {
        startTime = Time.time;
        playerSpeed = 2.0f;
        deaths = 0;
        collectibles = 0;
        SceneManager.LoadScene("LevelOne");
        retryButton.gameObject.SetActive(false);
        levelUI.SetActive(true);
        startButton.gameObject.SetActive(false);
        startUI.SetActive(false);
        winText.text = "";
    }

    private void ReloadCurrentLevel()
    {
        retryButton.gameObject.SetActive(false);
        startUI.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LoadLevelTwo()
    {
        
        SceneManager.LoadScene("LevelTwo");
        retryButton.gameObject.SetActive(false);
        levelUI.SetActive(true);
        startButton.gameObject.SetActive(false);
        startUI.SetActive(false);
    }

    public void LoadLevelThree()
    {
        SceneManager.LoadScene("LevelThree");
        retryButton.gameObject.SetActive(false);
        levelUI.SetActive(true);
        startButton.gameObject.SetActive(false);
        startUI.SetActive(false);
    }

    public void WinLevel()
    {
        retryButton.gameObject.SetActive(false);
        startUI.SetActive(true);
        winText.text = "YOU WON!\n" +
                       "Time: " + timeCounterText.text + "\n" +
                       "Deaths: " + deaths + "\n" +
                       "Collectibles: " + collectibles;
        startButton.gameObject.SetActive(true);
        retryButton.gameObject.SetActive(false);
        levelUI.SetActive(false);        
    }
}
