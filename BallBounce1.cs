using DG.Tweening.Core.Easing;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce1 : MonoBehaviour
{
    public Rigidbody rb;

    public Transform ballPrefab;


    private float bounceForce = 500;
 
   // public float highScore;







    public ParticleSystem particleEffect;

    SpawnUmbrella playerScript;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();


    }

   

    // Update is called once per frame
    void Update()
    {
        



    }

    private void FixedUpdate()
    {
        transform.Rotate(0f, 0f, -4f);
    }

    public IEnumerator Wait()
    {
        yield return new WaitForSeconds(.1f);
    }

   
    private void OnCollisionEnter(Collision other)
    {
      






        if (other.gameObject.tag == "ExampleUmbrella")
        {
            float particleLocation = ballPrefab.transform.position.y - 1;
            particleEffect.transform.position = new Vector3(ballPrefab.transform.position.x, ballPrefab.transform.position.y - .5f, ballPrefab.transform.position.z);
            particleEffect.Play();

            rb.AddForce(0, bounceForce, 0);
            StartCoroutine(WaitToSpawn());

        }



       

    }

   
   
    public IEnumerator WaitToSpawn()
    {
        yield return new WaitForSeconds(1);
    }

    public IEnumerator WaitToWrap()
    {
        yield return new WaitForSeconds(.2f);
    }

    




}
