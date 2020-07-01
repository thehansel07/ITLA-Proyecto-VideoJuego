using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movimiento : MonoBehaviour
{
    //Aqui se encuentra el Area de Movimiento de la Nabe
    //Y Disparo de jugador 
    [SerializeField] float velocidad;
    [SerializeField] SoundManeger soundManeger;
    public Transform lugardisparo;


    Rigidbody2D rb;
    [SerializeField] GameObject jugadorPrefab;

    [SerializeField] Vector3 jugadorForce ;
    public float targetTime = 50f;
    public float clockTime = 1.0f;
    public UIManeger UIMgr;
    
    public float veldisparo;

    private float nextdisparo; 


    
    void Start()
    {
       InvokeRepeating("timerEnded", 10.0f, 10.0f);
       UIMgr = GameObject.FindGameObjectWithTag("UIManeger").GetComponent<UIManeger>();
        rb = GetComponent<Rigidbody2D>();
        HealthBarHandler.SetHealthBarValue(1);
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1") && Time.time > nextdisparo){
            nextdisparo = Time.time + veldisparo+1;
            Disparo();
        }
         if(Input.GetKey(KeyCode.RightArrow)){
            transform.Translate(0,0.07f,0);

        }
         if(Input.GetKey(KeyCode.LeftArrow)){
            transform.Translate(0,-0.07f,0);

        }

        targetTime -= Time.deltaTime;
        clockTime -= Time.deltaTime;
        if (clockTime <=0.0f)
        {
            UIMgr.AddTimer(1);
            clockTime = 1.0f;
        }

        if (HealthBarHandler.GetHealthBarValue()==0f)
        {

            // SceneManager.LoadScene(2);
            Debug.Log("se murio por vida");
            
        }

        
    }
     
        
    /*private void FixedUpdate() {
        Vector2 direccion = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        direccion.Normalize();
        float rotateAmount = Vector3.Cross(direccion,transform.right).z;
        rb.angularVelocity = rotateAmount * velocidad * Time.deltaTime;


        
    }*/

    void Disparo(){
        soundManeger.PlaySound();
        GameObject jugador = Instantiate(jugadorPrefab, transform.position, transform.rotation);
        jugador.GetComponent<Rigidbody2D>().AddRelativeForce(jugadorForce);
        Destroy(jugador, 3f);
        
    }
   

    void timerEnded()
    {
        HealthBarHandler.SetHealthBarValue(HealthBarHandler.GetHealthBarValue() - 0.02f);
        UIMgr.AddScore(-5);
        
    }

    private void OnBecameInvisible() {  
        SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
        
    }



}
