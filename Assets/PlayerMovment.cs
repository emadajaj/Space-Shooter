using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovment : MonoBehaviour
{
    ScoreLogic ScoreIs;
    public Animator kaka;
    public GameObject projictal;
    public float Pspeed = 0.7f;
    public float ShootingSpeed = 0.7f;
    public bool isShooting = true;
 
    void Start()
    {
        kaka = GetComponent<Animator>();
      
       
    }

   
    void Update()
    {
        PlayerMovmentt();
     

    }
    void PlayerMovmentt(){
        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x >= -8.3)
        { 
        transform.Translate(-Pspeed, 0, 0);
    }
        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x <= 8.3)
        {
            transform.Translate(Pspeed, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spawnPro();
            
         
        }
      
    }

    void OnCollisionEnter2D(Collision2D baba)
    {

        if (baba.gameObject.tag == "ifTenemy")
        {
            kaka.SetInteger("Life", 0);
            StartCoroutine(proShootTimer());
            proShootTimer();
            Destroy(baba.gameObject);
           
            SceneManager.LoadScene("SampleScene");

        }

    }


    IEnumerator proShootTimer()
    {


        yield return new WaitForSecondsRealtime(10);
           
        
    }
    void spawnPro() {
        Instantiate(projictal, transform.position, Quaternion.identity);
        
    }

}
