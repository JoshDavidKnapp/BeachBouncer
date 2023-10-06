using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public GameObject birdie;
   // public GameObject seagull;
    public GameObject drone;
    //public GameObject airplane;
    public GameObject heli;
    public GameObject meteor;
    public GameObject ufo;

    public GameObject ball;

    public bool canSpawn = true;

    public int obstacleToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitFor());

    }

    // Update is called once per frame
    void Update()
    {
        ball = GameObject.FindGameObjectWithTag("Ball");

        Transform ballTransform = ball.transform;
            

        if (((int)ballTransform.position.y % 10 == 0) && canSpawn == true && obstacleToSpawn == 1 && ball.transform.position.y > 3000)
        {
            Instantiate(birdie, new Vector3(-6, ballTransform.position.y -1 , ballTransform.position.z), Quaternion.identity);
            canSpawn = false;
        }

        if (((int)ballTransform.position.y % 10 == 0) && canSpawn == true && obstacleToSpawn == 2 && ball.transform.position.y > 3000)
        {
            Instantiate(drone, new Vector3(Random.Range(-3, 3), ballTransform.position.y + 10, ballTransform.position.z), Quaternion.identity);
            canSpawn = false;
        }

        if (((int)ballTransform.position.y % 10 == 0) && canSpawn == true && obstacleToSpawn == 3 && ball.transform.position.y > 3000)
        {
            Instantiate(heli, new Vector3(Random.Range(-3, 3), ballTransform.position.y + 10, ballTransform.position.z), Quaternion.identity);
            canSpawn = false;
        }

        if (((int)ballTransform.position.y % 10 == 0) && canSpawn == true && obstacleToSpawn == 4 && ball.transform.position.y > 3000)
        {
            Instantiate(meteor, new Vector3(Random.Range(-3, 3), ballTransform.position.y + 10, ballTransform.position.z), Quaternion.identity);
            canSpawn = false;
        }

        if (((int)ballTransform.position.y % 10 == 0) && canSpawn == true && obstacleToSpawn == 5 && ball.transform.position.y > 3000)
        {
            Instantiate(ufo, new Vector3(Random.Range(-3, 3), ballTransform.position.y + 10, ballTransform.position.z), Quaternion.identity);
            canSpawn = false;
        }
    }

    public IEnumerator WaitFor()
    {
        obstacleToSpawn = Random.Range(1, 6);
        Debug.Log(obstacleToSpawn);
        yield return new WaitForSeconds(5);
        canSpawn = true;

        StartCoroutine(WaitFor());
    }
}
