using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private const string HIGH_SCORE = "High Score";

    public static GameManager instance;
    void Awake() {
        _MakeSingleInstace();
        IsGameStratedForTheFirstTime();
    }

    void IsGameStratedForTheFirstTime() {
        if (!PlayerPrefs.HasKey("IsGameStratedForTheFirstTime")) {
            PlayerPrefs.SetInt(HIGH_SCORE,0);
            PlayerPrefs.SetInt("IsGameStratedForTheFirstTime",0);
        }
    }

    void _MakeSingleInstace() {
        if (instance != null) {
            Destroy (gameObject);
        } else {
            instance = this;
            DontDestroyOnLoad (gameObject);
        }
    }

    public void SetHighScore(int score){
        PlayerPrefs.SetInt(HIGH_SCORE, score);
    }
    public int GetHighScore(){
        return PlayerPrefs.GetInt(HIGH_SCORE);
    }
}
