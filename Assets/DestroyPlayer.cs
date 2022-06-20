using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DestroyPlayer : MonoBehaviour
{
    public Animator kaka;

    // Update is called once per frame
    void Start()
    {
       
        kaka = GetComponent<Animator>();
    }
    void Update() {
        if (Input.GetKeyDown(KeyCode.Mouse1)) { Time.timeScale = 0; };
    }
    void OnCollisionEnter2D(Collision2D baba)
    {

        if (baba.gameObject.tag == "Player")
        {
           
            Destroy(baba.gameObject);
            kaka.SetBool("Life", true);
           
            SceneManager.LoadScene("SampleScene");

        }

    }
}