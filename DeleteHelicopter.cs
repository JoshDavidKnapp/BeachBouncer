using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteHelicopter : MonoBehaviour
{
    public bool gameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ball")
        {
            gameOver = true;
        }
    }
}
