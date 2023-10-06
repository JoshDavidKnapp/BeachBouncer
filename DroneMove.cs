using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneMove : MonoBehaviour
{
    //public Transform drone;

    private Rigidbody rb;
    private Transform droneTransform;
  



    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        droneTransform = transform;
        StartCoroutine(Thrust());
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
    }

    public IEnumerator Thrust()
    {

        rb.AddForce(0, 50, 0);
        yield return new WaitForSeconds(2);
        rb.velocity = new Vector3(0f, 0f, 0f);
        rb.AddForce(0, -50, 0);
        yield return new WaitForSeconds(2);
        rb.AddForce(0, 50, 0);

        StartCoroutine(Thrust());
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ball")
        {
            StartCoroutine(WaitToDestroy());
        }
    }

    public IEnumerator WaitToDestroy()
    {
        yield return new WaitForSeconds(5);
        Destroy(this.gameObject);
    }

}
