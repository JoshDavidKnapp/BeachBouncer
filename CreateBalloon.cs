using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBalloon : MonoBehaviour
{

    public GameObject ball;
    public GameObject balloon;
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

        if (((int)ballTransform.position.y % 10 == 0) && ((int)ballTransform.position.y > 50) && canSpawn == true)
        {
            Instantiate(balloon, new Vector3(Random.Range(-20,-12), ballTransform.position.y , ballTransform.position.z), Quaternion.identity);
            canSpawn = false;
            StartCoroutine(WaitFor());
        }
    }

    public IEnumerator WaitFor()
    {
        yield return new WaitForSeconds(30);
        canSpawn = true;
    }

}
