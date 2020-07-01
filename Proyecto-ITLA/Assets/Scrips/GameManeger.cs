using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManeger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadLeve1(int level){
        SceneManager.LoadScene("Main");



    }


    public void LoadLeve2(int level){
        SceneManager.LoadScene("Controles");



    }

    public void LoadLeve3(int level){
        print("Saliendo del juego");
        Application.Quit();



    }

        public void LoadLeve4(int level){
        SceneManager.LoadScene("Inicio");



    }


     public void LoadLeve5(int level){
        SceneManager.LoadScene("Reglas");
        



    }

    public void LoadLeve6(int level){
        SceneManager.LoadScene("Historia");



    }

     public void LoadLeve7(int level){
        SceneManager.LoadScene("Objectivo");



    }
}
