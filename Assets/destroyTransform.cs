using System.Collections;
using System.Collections.Generic;
using System.Collections;
using UnityEngine;


public class destroyTransform : MonoBehaviour
{
    public GameObject Particale;
    ScoreLogic addToScore;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D enemy)
    {
     
            if (enemy.gameObject.tag == "enemy")
            {
                spawnParticale(enemy.transform.position);
                Destroy(enemy.gameObject);
                addToScore = GameObject.FindGameObjectWithTag("SCO").GetComponent<ScoreLogic>();
                addToScore.Addtoscore();
            }
        
    }
   void spawnParticale(Vector2 temPositoin)
    {
        Instantiate(Particale, temPositoin, Quaternion.identity);
    }
    
}
