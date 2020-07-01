using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class UIManeger : MonoBehaviour
{
    int tiempo = 0;
    int score = 0;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI timerText;
    private HealthBarHandler health;

    public void AddScore(int punto){
        score= score + (punto);
        if (score >= 500)
        {
            print("Siguiente Nivel");

            
            //SceneManager.LoadScene("Ganador", LoadSceneMode.Single);

        }else if(score <= -1)
        {
            SceneManager.LoadScene(2);

        }
        scoreText.text = score.ToString();
       


    }
    public void AddTimer(int punto)
    {
        tiempo += punto;
        timerText.text = tiempo.ToString();
    }
    
    
   
}
