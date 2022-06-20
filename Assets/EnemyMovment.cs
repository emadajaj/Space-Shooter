using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovment : MonoBehaviour
{
    public float SpeedDown = 0.5f;
    public float SpeedLR = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        eneMove();
    }
    void eneMove() {
        transform.Translate(0, -SpeedDown, 0);
    }
}
