using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Globo : MonoBehaviour
{
    //Globos
    [SerializeField] Vector3 force;
    [SerializeField] Sprite[] ballonSprites;
    private UIManeger UIMgr;
    

    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        UIMgr = GameObject.FindGameObjectWithTag("UIManeger").GetComponent<UIManeger>();
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();


        spriteRenderer.sprite = ballonSprites[Random.Range(0,4)];
        if (GetComponent<SpriteRenderer>().sprite == ballonSprites[0])
        {
            rb.mass = 0.6f;
        }
        else
        {
            rb.mass = Random.Range(1f, 3f);
        }






        transform.position = new Vector3(Random.Range(-2.25f, 2.25f),transform.position.y, transform.position.z);


        force = new Vector3(Random.Range(-100,100),Random.Range(150,250),0);
        rb.AddForce(force);
        
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collider) {
        if(collider.gameObject.tag == "Techo"){
            Destroy(this.gameObject);


        }
        else if(collider.gameObject.tag == "disparo"){
             Destroy(this.gameObject);
             
 
            if (GetComponent<SpriteRenderer>().sprite == ballonSprites[0])
            {


                UIMgr.AddScore(10);
                HealthBarHandler.SetHealthBarValue(HealthBarHandler.GetHealthBarValue() + 0.10f);
            }
            else
            {
                UIMgr.AddScore(1);
                HealthBarHandler.SetHealthBarValue(HealthBarHandler.GetHealthBarValue() + 0.01f);


            }
              Destroy(this.gameObject);
              Destroy(collider.gameObject);
              


        }
    
        
    }
    




}
