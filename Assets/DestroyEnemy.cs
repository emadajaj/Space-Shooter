using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class DestroyEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D baba)
    {

        if (baba.gameObject.tag == "ifTenemy")
        {
            Destroy(baba.gameObject);
            
        }

    }
}
