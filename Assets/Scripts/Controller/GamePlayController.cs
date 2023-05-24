using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlayController : MonoBehaviour
{
    public static GamePlayController instance;

    [SerializeField]
    private Button instructionButton; 

    [SerializeField]
    private Image broneMedal, whiteMedal, goldMedal;

    [SerializeField]
    private Text scoreCurrent, endScore, bestScore;

    [SerializeField]
    private GameObject gameOverPanel;

    void Awake () {
        Time.timeScale = 0;
        _MakeInstance();
    }

    void _MakeInstance() {
        if (instance == null) {
            instance = this;
        }
    }

    public void _InstructionButton() {
        Time.timeScale = 1;
        instructionButton.gameObject.SetActive(false);
    }

    public void _SetScore(int score) {
        scoreCurrent.text = "" + score;
    }

    public void _ShowPanel(int score) {
        gameOverPanel.SetActive(true);
             if (score < 5) {
            broneMedal.gameObject.SetActive(true);
        } else if (score < 7) {
            whiteMedal.gameObject.SetActive(true);
        } else goldMedal.gameObject.SetActive(true);
        endScore.text = "" + score;
        if (score > GameManager.instance.GetHighScore()) {
            GameManager.instance.SetHighScore(score);
        }
        bestScore.text = "" + GameManager.instance.GetHighScore();
    }

    public void _MenuButton() {
        Application.LoadLevel("MainMenu");
    }

    public void _ResumeButton() {
        Application.LoadLevel("GamePlay");
    }

    /*public void _PauseButton() {
        Time.timeScale = 0;
        pausePanel.SetActive (true);
    }
    public void _ResumePauseButton() {
        Time.timeScale = 1;
        pausePanel.SetActive (false);
    }*/
}
