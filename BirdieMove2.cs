using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdieMove2 : MonoBehaviour
{
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();

        rb.AddForce(Random.Range(-500f, -700f), Random.Range(400f, 600f), 0);


        StartCoroutine(WaitFor());
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "RaycastTarget")
        {
            Physics.IgnoreCollision(collision.collider, GetComponent<Collider>());
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "RaycastTarget")
        {
            Physics.IgnoreCollision(collision.collider, GetComponent<Collider>());
        }
    }

    public IEnumerator WaitFor()
    {
        yield return new WaitForSeconds(5);
        Destroy(this.gameObject);
    }
}
