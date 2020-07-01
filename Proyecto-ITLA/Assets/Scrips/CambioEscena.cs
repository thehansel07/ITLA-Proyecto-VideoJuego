using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
    // Start is called before the first frame update
   public void CambioDeEscenas(string nombre){
       SceneManager.LoadScene(nombre);




   }

      public void Salir(string nombre){
          print("Saliendo del Juego");
          Application.Quit();
        




      }


    
}
