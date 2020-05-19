using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;


public class GameSession : MonoBehaviour {

   
    
    // config params
    [Range(0.1f, 10f)] [SerializeField] float gameSpeed = 1f;
    [SerializeField] int pointsPerBlockDestroyed = 83;
    [SerializeField]  TextMeshProUGUI scoreText;
    [SerializeField] bool isAutoPlayEnabled;
   
    
    int hzg ; 

    // state variables
    [SerializeField] public static int currentScore = 0;
    
  

    private void Awake()
    {
        int gameStatusCount = FindObjectsOfType<GameSession>().Length;
        if (gameStatusCount > 1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public void Start()
    {
        scoreText.text = currentScore.ToString();    
    }
    public void reset()
    {
        //scoreText.text = currentScore.ToString();    
    }


    // Update is called once per frame
    void Update () {
        Time.timeScale = gameSpeed;
	}

    public void AddToScore()
    {
        currentScore += pointsPerBlockDestroyed;
        scoreText.text = currentScore.ToString();
        hzg=int.Parse(scoreText.text);
        Scores.WriteString(scoreText.text);
        Scores.ReadString();
    }
    //public  static void resetScore(){
      //  currentScore =0;
        //scoreText.text="0";
    //}

    public void ResetGame()
    {
        
        Destroy(gameObject);
    }
    public bool IsAutoPlayEnabled()
    {
        return isAutoPlayEnabled;
    }
}
