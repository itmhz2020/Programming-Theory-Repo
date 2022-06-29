using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager s_Instance {private set; get;}
    public float m_Score;
    public bool m_IsRestart;
    public bool m_IsGameOver;
    public TMP_Text m_ScoreText;
    public GameObject m_LoseScreen;
    public GameObject m_InGameScreen;
    
    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        if (s_Instance == null)
        {
            s_Instance = this;
        }
    }

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        m_Score = 0;
        m_ScoreText.text = "score: " + m_Score;
        m_InGameScreen.SetActive(true);
        m_LoseScreen.SetActive(false);
    }

    public void UpdateScore(int _Score)
    {
        m_Score += _Score;
        m_ScoreText.text = "score: " + m_Score;
    }

    public void GameOver()
    {
        m_InGameScreen.SetActive(false);
        m_LoseScreen.SetActive(true);
    }

    public void GameRestart()
    {
        if (m_IsRestart)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        } 
    }
}
