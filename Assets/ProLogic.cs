using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProLogic : MonoBehaviour
{
    public float transSpeed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Shot();
      
    }
    void Shot() {
        transform.Translate(0, transSpeed, 0);
    }
    

}
