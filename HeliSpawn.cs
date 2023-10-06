using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeliSpawn : MonoBehaviour
{
    public GameObject ball;
    public GameObject heli;
    public bool canSpawn = true;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        ball = GameObject.FindGameObjectWithTag("Ball");

        Transform ballTransform = ball.transform;

        if(ball == null)
        {
            Debug.Log("NO BALL");
            StartCoroutine(DestroyHeli());
        }




        if (((int)ballTransform.position.y == 50) && canSpawn == true)
        {
            Instantiate(heli, new Vector3(Random.Range(-3, 3), ballTransform.position.y + 10, ballTransform.position.z), Quaternion.identity);
            canSpawn = false;
            StartCoroutine(WaitFor());
        }
        else if (((int)ballTransform.position.y == 925 ) && canSpawn == true)
        {

            Instantiate(heli, new Vector3(Random.Range(-3, 3), ballTransform.position.y + 10, ballTransform.position.z), Quaternion.identity);
            canSpawn = false;
            StartCoroutine(WaitFor());
        }
        else if (((int)ballTransform.position.y == 975) && canSpawn == true)
        {

            Instantiate(heli, new Vector3(Random.Range(-3, 3), ballTransform.position.y + 10, ballTransform.position.z), Quaternion.identity);
            canSpawn = false;
            StartCoroutine(WaitFor());
        }
        else if (((int)ballTransform.position.y == 1050) && canSpawn == true)
        {

            Instantiate(heli, new Vector3(Random.Range(-3, 3), ballTransform.position.y + 10, ballTransform.position.z), Quaternion.identity);
            canSpawn = false;
            StartCoroutine(WaitFor());
        }
        else if (((int)ballTransform.position.y == 1100) && canSpawn == true)
        {

            Instantiate(heli, new Vector3(Random.Range(-3, 3), ballTransform.position.y + 10, ballTransform.position.z), Quaternion.identity);
            canSpawn = false;
            StartCoroutine(WaitFor());
        }
        else if (((int)ballTransform.position.y == 1130) && canSpawn == true)
        {

            Instantiate(heli, new Vector3(Random.Range(-3, 3), ballTransform.position.y + 10, ballTransform.position.z), Quaternion.identity);
            canSpawn = false;
            StartCoroutine(WaitFor());
        }
        else if (((int)ballTransform.position.y == 1200) && canSpawn == true)
        {

            Instantiate(heli, new Vector3(Random.Range(-3, 3), ballTransform.position.y + 10, ballTransform.position.z), Quaternion.identity);
            canSpawn = false;
            StartCoroutine(WaitFor());
        }
        else if (((int)ballTransform.position.y == 1260) && canSpawn == true)
        {
            Instantiate(heli, new Vector3(Random.Range(-3, 3), ballTransform.position.y + 10, ballTransform.position.z), Quaternion.identity);
            canSpawn = false;
            StartCoroutine(WaitFor());
        }
        else if (((int)ballTransform.position.y == 1340) && canSpawn == true)
        {

            Instantiate(heli, new Vector3(Random.Range(-3, 3), ballTransform.position.y + 10, ballTransform.position.z), Quaternion.identity);
            canSpawn = false;
            StartCoroutine(WaitFor());
        }
        else if (((int)ballTransform.position.y == 1400) && canSpawn == true)
        {
            Instantiate(heli, new Vector3(0, ballTransform.position.y + 10, ballTransform.position.z), Quaternion.identity);
            canSpawn = false;
            StartCoroutine(WaitFor());
        }
    }

    public IEnumerator WaitFor()
    {
        yield return new WaitForSeconds(10);
        canSpawn = true;
    }

    public IEnumerator DestroyHeli()
    {
        yield return new WaitForSeconds(2);
        if(ball == null)
        {
            Destroy(this.gameObject);
        }
    }
}
