using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeliMove : MonoBehaviour
{
    public GameObject ball;

    public GameObject bullet;

    private float speed = 5;

    private bool follow = false;

    private bool moveUp = false;

    public GameObject floor;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Shoot());
        StartCoroutine(DestroyThis());
      
    }

    // Update is called once per frame
    void Update()
    {


        floor = GameObject.FindGameObjectWithTag("Floor");
        DeleteHelicopter heliScript = floor.GetComponent<DeleteHelicopter>();

        if(heliScript.gameOver ==  true)
        {
            Destroy(this.gameObject);
        }

        ball = GameObject.FindGameObjectWithTag("Ball");
        Transform ballTransform = ball.transform;

    }
    private void LateUpdate()
    {
        
    }

    private void FixedUpdate()
    {
        if(follow == true)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }

        if (ball != null && ball.transform.position.y - this.gameObject.transform.position.y > 20)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Ball")
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Ball")
        {
            StartCoroutine(MoveUp());
                

            
        }
    }

   

    public IEnumerator Shoot()
    {
        yield return new WaitForSeconds(.5f);
        Instantiate(bullet, new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y - .3f, this.gameObject.transform.position.z), Quaternion.identity);
        StartCoroutine(Shoot());
    }

    public IEnumerator MoveUp()
    {
        follow = true;
        yield return new WaitForSeconds(2f);
        follow = false;

    }

    public IEnumerator DestroyThis()
    {
        yield return new WaitForSeconds(1);
        //Destroy(this.gameObject)
    }
}
