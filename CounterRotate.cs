using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterRotate : MonoBehaviour
{
    public GameObject targ;


    // Start is called before the first frame update
    void Start()
    {
        GameObject theBall = GameObject.Find("Manager");
        Store spawnBall = theBall.GetComponent<Store>();
        targ = spawnBall.ballToSpawn;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targ.transform.position, 10f);
    }

    private void FixedUpdate()
    {
    }
}
