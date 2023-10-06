using DG.Tweening.Core.Easing;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{
    public Rigidbody rb;

    public Transform ballPrefab;

    public GameObject gameOverPanel;

    public TMPro.TextMeshProUGUI scoreText;

    private float bounceForce = 500;
 
   // public float highScore;

    public int score;

    public TMPro.TextMeshProUGUI gameOverScore;

    public bool canWrap = true;

    public GameObject scoreHolder;

    public ScoreCounter scoreCounterScore;

    public Camera cam;

    public ParticleSystem particleEffect;

    public AudioSource bounceSound;

    public AudioSource popSound;

    public AudioSource thudSound;

    public AudioSource seagullCall;

    SpawnUmbrella playerScript;

    public float rotationSpeed = 4f;

    public int bestScore = 0;

    public GameObject hsimage;

    public GameObject net;

    public GameObject fireChild;

    private SphereCollider collider;

    private bool isThrusting = false;

    //public bool gameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        //gameOver = false;
        rb = gameObject.GetComponent<Rigidbody>();
        GameObject umbrella = GameObject.Find("Manager");

        collider = this.gameObject.GetComponent<SphereCollider>();

        playerScript = umbrella.GetComponent<SpawnUmbrella>();


    }

   

    // Update is called once per frame
    void Update()
    {
        

        score = Mathf.Max(score, Mathf.RoundToInt(ballPrefab.transform.position.y));

        scoreText.text = "Score: " + score.ToString();

        if(rb.velocity.y >= -2)
        {
            playerScript.canSpawn = false;
        }
        if (rb.velocity.y < -2)
        {
            playerScript.canSpawn = true;
        }

    }

    private void FixedUpdate()
    {
        transform.Rotate(0f, 0f, rotationSpeed);

        if (isThrusting)
        {
            rb.AddForce(0, 45, 0);
        }
        
        //fireChild.Rotate(0f, 0f, -rotationSpeed);
    }

    public IEnumerator Wait()
    {
        yield return new WaitForSeconds(.1f);
    }

   
   
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Seagull")
        {
            seagullCall.Play();
        }

        if(other.gameObject.tag == "Wall")
        {
            thudSound.Play();
        }



        if (other.gameObject.tag == "Umbrella")
        {
            float particleLocation = ballPrefab.transform.position.y - 1;
            particleEffect.transform.position = new Vector3(ballPrefab.transform.position.x, ballPrefab.transform.position.y -.5f , ballPrefab.transform.position.z);
            particleEffect.Play();
            bounceSound.Play();


            rb.AddForce(0, bounceForce, 0);
            StartCoroutine(WaitToSpawn());
            
        }


        if (other.gameObject.tag == "ExampleUmbrella")
        {
            float particleLocation = ballPrefab.transform.position.y - 1;
            particleEffect.transform.position = new Vector3(ballPrefab.transform.position.x, ballPrefab.transform.position.y - .5f, ballPrefab.transform.position.z);
            particleEffect.Play();

            rb.AddForce(0, bounceForce, 0);
            StartCoroutine(WaitToSpawn());

        }



        if (other.gameObject.tag == "Floor")
        {
            //gameOver = true;

            gameObject.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);

            net.SetActive(false);

            rb.velocity = new Vector3(0, 0, 0);
            this.gameObject.SetActive(false);
            print("Collided with ground");

            gameOverScore.text = score.ToString();
            gameOverPanel.SetActive(true);
            scoreCounterScore.score += score;

            if (score > scoreCounterScore.highScore1)
            {
                hsimage.SetActive(true);

                scoreCounterScore.oldscore1 = scoreCounterScore.highScore1;
                scoreCounterScore.oldscore2 = scoreCounterScore.highScore2;
                scoreCounterScore.oldscore3 = scoreCounterScore.highScore3;
                scoreCounterScore.oldscore4 = scoreCounterScore.highScore4;
                scoreCounterScore.oldscore5 = scoreCounterScore.highScore5;

                scoreCounterScore.highScore1 = score;

                scoreCounterScore.highScore2 = scoreCounterScore.oldscore1;
                scoreCounterScore.highScore3 = scoreCounterScore.oldscore2;
                scoreCounterScore.highScore4 = scoreCounterScore.oldscore3;
                scoreCounterScore.highScore5 = scoreCounterScore.oldscore4;

                PlayerPrefs.SetInt("HighScore1", 1);
                PlayerPrefs.SetInt("HighScore2", 1);
                PlayerPrefs.SetInt("HighScore3", 1);
                PlayerPrefs.SetInt("HighScore4", 1);
                PlayerPrefs.SetInt("HighScore5", 1);
            }

            if (score > scoreCounterScore.highScore2 && score < scoreCounterScore.highScore1)
            {

                hsimage.SetActive(false);


                scoreCounterScore.oldscore1 = scoreCounterScore.highScore1;
                scoreCounterScore.oldscore2 = scoreCounterScore.highScore2;
                scoreCounterScore.oldscore3 = scoreCounterScore.highScore3;
                scoreCounterScore.oldscore4 = scoreCounterScore.highScore4;
                scoreCounterScore.oldscore5 = scoreCounterScore.highScore5;

                scoreCounterScore.highScore2 = score;

                scoreCounterScore.highScore3 = scoreCounterScore.oldscore2;
                scoreCounterScore.highScore4 = scoreCounterScore.oldscore3;
                scoreCounterScore.highScore5 = scoreCounterScore.oldscore4;

                PlayerPrefs.SetInt("HighScore1", 1);
                PlayerPrefs.SetInt("HighScore2", 1);
                PlayerPrefs.SetInt("HighScore3", 1);
                PlayerPrefs.SetInt("HighScore4", 1);
                PlayerPrefs.SetInt("HighScore5", 1);

            }

            if (score > scoreCounterScore.highScore3 && score < scoreCounterScore.highScore2)
            {
                hsimage.SetActive(false);

                scoreCounterScore.oldscore1 = scoreCounterScore.highScore1;
                scoreCounterScore.oldscore2 = scoreCounterScore.highScore2;
                scoreCounterScore.oldscore3 = scoreCounterScore.highScore3;
                scoreCounterScore.oldscore4 = scoreCounterScore.highScore4;
                scoreCounterScore.oldscore5 = scoreCounterScore.highScore5;

                scoreCounterScore.highScore3 = score;

                scoreCounterScore.highScore4 = scoreCounterScore.oldscore3;
                scoreCounterScore.highScore5 = scoreCounterScore.oldscore4;

                PlayerPrefs.SetInt("HighScore1", 1);
                PlayerPrefs.SetInt("HighScore2", 1);
                PlayerPrefs.SetInt("HighScore3", 1);
                PlayerPrefs.SetInt("HighScore4", 1);
                PlayerPrefs.SetInt("HighScore5", 1);
            }

            if (score > scoreCounterScore.highScore4 && score < scoreCounterScore.highScore3)
            {
                hsimage.SetActive(false);

                scoreCounterScore.oldscore1 = scoreCounterScore.highScore1;
                scoreCounterScore.oldscore2 = scoreCounterScore.highScore2;
                scoreCounterScore.oldscore3 = scoreCounterScore.highScore3;
                scoreCounterScore.oldscore4 = scoreCounterScore.highScore4;
                scoreCounterScore.oldscore5 = scoreCounterScore.highScore5;

                scoreCounterScore.highScore4 = score;

                scoreCounterScore.highScore5 = scoreCounterScore.oldscore4;

                PlayerPrefs.SetInt("HighScore1", 1);
                PlayerPrefs.SetInt("HighScore2", 1);
                PlayerPrefs.SetInt("HighScore3", 1);
                PlayerPrefs.SetInt("HighScore4", 1);
                PlayerPrefs.SetInt("HighScore5", 1);
            }

            if (score > scoreCounterScore.highScore5 && score < scoreCounterScore.highScore4)
            {
                hsimage.SetActive(false);

                scoreCounterScore.highScore5 = score;

                PlayerPrefs.SetInt("HighScore1", 1);
                PlayerPrefs.SetInt("HighScore2", 1);
                PlayerPrefs.SetInt("HighScore3", 1);
                PlayerPrefs.SetInt("HighScore4", 1);
                PlayerPrefs.SetInt("HighScore5", 1);
            }

            if (score < scoreCounterScore.highScore5)
            {
                hsimage.SetActive(false);

                PlayerPrefs.SetInt("HighScore1", 1);
                PlayerPrefs.SetInt("HighScore2", 1);
                PlayerPrefs.SetInt("HighScore3", 1);
                PlayerPrefs.SetInt("HighScore4", 1);
                PlayerPrefs.SetInt("HighScore5", 1);

            }








            //CloudOnceServices.instance.SubmitScoreToLeaderboard(score);

            GameObject thePlayer = GameObject.Find("Manager");
            SpawnUmbrella spawnUmbrella = thePlayer.GetComponent<SpawnUmbrella>();
            spawnUmbrella.canSpawn = false;


            scoreText.gameObject.SetActive(false);
            score = 0;

            scoreHolder.SetActive(false);

            cam.transform.position = new Vector3(0, 0, 0);


        }

        if (other.gameObject.tag == "Net")
        {
            StartCoroutine(NetDespawn());
        }
    }

    private void OnTriggerEnter(Collider other)
    {
       

       if(other.gameObject.tag == "Balloon")
       {
            Destroy(other.gameObject);

            popSound.Play();

            int randomPowerup = Random.Range(0, 3);
            Debug.Log(randomPowerup);

            if(randomPowerup == 0)
            {
                gameObject.transform.localScale = new Vector3(2, 2, 2);
                StartCoroutine(NormalScale());
            }
            if (randomPowerup == 1)
            {
                net.SetActive(true);
                
            }
            if (randomPowerup == 2)
            {
                fireChild.gameObject.SetActive(true);
                collider.enabled = false;
                isThrusting = true;
                rb.velocity = new Vector3(0,0,0);
                transform.position = new Vector3(0, transform.position.y, 0);
                //rb.AddForce(0, 500, 0);
                StartCoroutine(SpeedPowerUp());
            }
        }
    }

    public IEnumerator SpeedPowerUp()
    {
        
        yield return new WaitForSeconds(2);
        isThrusting = false;
        yield return new WaitForSeconds(1);
        collider.enabled = true;

        fireChild.gameObject.SetActive(false);

    }

    public IEnumerator NormalScale()    
    {
        yield return new WaitForSeconds(10);
        gameObject.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);

    }

    public IEnumerator NetDespawn()
    {
        yield return new WaitForSeconds(.25f);
        net.SetActive(false);
    }

    public IEnumerator WaitToSpawn()
    {
        yield return new WaitForSeconds(1);
    }

    public IEnumerator WaitToWrap()
    {
        yield return new WaitForSeconds(.2f);
        canWrap = true;
    }

    




}
