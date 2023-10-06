using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birdie : MonoBehaviour
{
    public GameObject ball;
    public GameObject birdie;
    public bool canSpawn = true;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        ball = GameObject.FindGameObjectWithTag("Ball");
        
        Transform ballTransform = ball.transform;

        
       


        if (((int)ballTransform.position.y == 150)  && canSpawn == true)
        {
           Instantiate(birdie, new Vector3(-6, ballTransform.position.y-1, ballTransform.position.z), Quaternion.identity);
           canSpawn = false;
           StartCoroutine(WaitFor());
        }
       else if(((int)ballTransform.position.y == 200) && canSpawn == true)
       {
            Instantiate(birdie, new Vector3(-6, ballTransform.position.y-1, ballTransform.position.z), Quaternion.identity);
            canSpawn = false;
            StartCoroutine(WaitFor());
       }
       else if (((int)ballTransform.position.y == 250) && canSpawn == true)
       {
            Instantiate(birdie, new Vector3(-6, ballTransform.position.y-1, ballTransform.position.z), Quaternion.identity);
            canSpawn = false;
            StartCoroutine(WaitFor());
       }
       else if (((int)ballTransform.position.y == 300) && canSpawn == true)
       {
            Instantiate(birdie, new Vector3(-6, ballTransform.position.y-1, ballTransform.position.z), Quaternion.identity);
            canSpawn = false;
            StartCoroutine(WaitFor());
       }
    }

    public IEnumerator WaitFor()
    {
        yield return new WaitForSeconds(2);
        canSpawn = true;
    }

   

}
