using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Milestone : MonoBehaviour
{
    public GameObject milestone1;
    public GameObject milestone2;
    public GameObject milestone3;
    public GameObject milestone4;
    public GameObject milestone5;
    public GameObject milestone6;
    public GameObject milestone7;

    private GameObject ball;

    private bool can1 = true;
    private bool can2 = true;
    private bool can3 = true;
    private bool can4 = true;
    private bool can5 = true;
    private bool can6 = true;
    private bool can7 = true;
        

    // Start is called before the first frame update
    void Start()
    {
        GameObject theBall = GameObject.Find("Manager");
        Store spawnBall = theBall.GetComponent<Store>();
        ball = spawnBall.ballToSpawn;
    }

    // Update is called once per frame
    void Update()
    {
        if(ball.transform.position.y >= 50 && ball.transform.position.y < 52 && can1)
        {
            milestone1.SetActive(true);
            StartCoroutine(Mile1());
            can1 = false;

        }
        if (ball.transform.position.y >= 100 && ball.transform.position.y < 102 && can2)
        {
            milestone2.SetActive(true);
            StartCoroutine(Mile2());
            can2 = false;

        }
        if (ball.transform.position.y >= 250 && ball.transform.position.y < 252 && can3)
        {
            milestone3.SetActive(true);
            StartCoroutine(Mile3());
            can3 = false;

        }
        if (ball.transform.position.y >= 500 && ball.transform.position.y < 502 && can4)
        {
            milestone4.SetActive(true);
            StartCoroutine(Mile4());
            can4 = false;

        }
        if (ball.transform.position.y >= 1000 && ball.transform.position.y < 1002 && can5)
        {
            milestone5.SetActive(true);
            StartCoroutine(Mile5());
            can5 = false;

        }
        if (ball.transform.position.y >= 2500 && ball.transform.position.y < 2502 && can6)
        {
            milestone6.SetActive(true);
            StartCoroutine(Mile6());
            can6 = false;

        }
        if (ball.transform.position.y >= 5280 && ball.transform.position.y < 5282 && can7)
        {
            milestone7.SetActive(true);
            StartCoroutine(Mile7());
            can7 = false;

        }
    }

    public IEnumerator Mile1()
    {
        yield return new WaitForSeconds(2);
        milestone1.SetActive(false);
    }

    public IEnumerator Mile2()
    {
        yield return new WaitForSeconds(2);
        milestone2.SetActive(false);
    }

    public IEnumerator Mile3()
    {
        yield return new WaitForSeconds(2);
        milestone3.SetActive(false);
    }
    public IEnumerator Mile4()
    {
        yield return new WaitForSeconds(2);
        milestone4.SetActive(false);
    }
    public IEnumerator Mile5()
    {
        yield return new WaitForSeconds(2);
        milestone5.SetActive(false);
    }
    public IEnumerator Mile6()
    {
        yield return new WaitForSeconds(2);
        milestone6.SetActive(false);
    }
    public IEnumerator Mile7()
    {
        yield return new WaitForSeconds(2);
        milestone7.SetActive(false);
    }
}
