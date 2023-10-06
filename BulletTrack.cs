using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTrack : MonoBehaviour
{
    public GameObject ball;

    private Vector3 moveDir;
    private float speed = 50;
    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.FindGameObjectWithTag("Ball");

        Transform ballTransform = ball.transform;

        moveDir = (ball.transform.position - transform.position).normalized;
        StartCoroutine(DeleteMe());

       // Rigidbody rb = this.gameObject.GetComponent < Rigidbody >();

       // rb.AddForce(moveDir);
    }

    // Update is called once per frame
    void Update()
    {
        if(ball.activeInHierarchy)
        {
            transform.position += moveDir * speed * Time.deltaTime;

        }

    }

    private void FixedUpdate()
    {
       

    }

    public IEnumerator DeleteMe()
    {
        yield return new WaitForSeconds(2);
        Destroy(this.gameObject);
    }
}
