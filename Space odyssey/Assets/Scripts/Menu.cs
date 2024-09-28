using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    //public TMPro bestScoreTxt; 
    public TMP_Text bestScoreText;
    public TMP_Text lastScoreText;
    public Button Play;
    public AudioSource playSfx;
    private void Start()
    {
        int bestScore = PlayerPrefs.GetInt("BestScore", 0);
        bestScoreText.text = "Best Score : "+ /*"\n" +*/ bestScore;
        int lastScore = PlayerPrefs.GetInt("lastScore", 0);
        lastScoreText.text = "Last Score : "+ /*"\n" +*/ lastScore;
        Play.onClick.AddListener(PlaySound);
    }

   void PlaySound()
    {
        playSfx.Play();
    }
    public void StartGame()
    {
        SceneManager.LoadScene("MainSc�ne");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    
}
