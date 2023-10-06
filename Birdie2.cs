using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birdie2 : MonoBehaviour
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

        if (((int)ballTransform.position.y == 125) && canSpawn == true)
        {
            Instantiate(birdie, new Vector3(6, ballTransform.position.y-1, ballTransform.position.z), Quaternion.Euler(180, 0, 180));
            canSpawn = false;
            StartCoroutine(WaitFor());
        }
        else if (((int)ballTransform.position.y == 175) && canSpawn == true)
        {
            Instantiate(birdie, new Vector3(6, ballTransform.position.y-1, ballTransform.position.z), Quaternion.Euler(180, 0, 180));
            canSpawn = false;
            StartCoroutine(WaitFor());
        }
        else if (((int)ballTransform.position.y == 225) && canSpawn == true)
        {
            Instantiate(birdie, new Vector3(6, ballTransform.position.y-1, ballTransform.position.z), Quaternion.Euler(180, 0, 180));
            canSpawn = false;
            StartCoroutine(WaitFor());
        }
        else if (((int)ballTransform.position.y == 275) && canSpawn == true)
        {
            Instantiate(birdie, new Vector3(6, ballTransform.position.y-1, ballTransform.position.z), Quaternion.Euler(180, 0, 180));
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
