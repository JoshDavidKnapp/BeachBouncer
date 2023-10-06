using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMeteor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        Rigidbody rb = GetComponent<Rigidbody>();

        rb.AddForce(Random.Range(800f, 1100f), 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Floor")
        {
            Destroy(this.gameObject);
        }

        if(other.gameObject.tag == "Ball")
        {
            Destroy(this.gameObject);
        }
    }

    
}
