using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteUmbrella : MonoBehaviour
{

   // private static DeleteUmbrella instance = null;

    //public GameObject particleEffectObject;

    //public ParticleSystem particleEffect;
    // Start is called before the first frame update


    
    private void Awake()
    {
       
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if the singleton hasn't been initialized yet
       
    }

    private void OnCollisionEnter(Collision other)
    {
      //  if(other.gameObject.tag == "Ball")
        //{

            //particleEffectObject = GameObject.Find("Puff");
            //particleEffectObject.gameObject.SetActive(true);

           // particleEffect = particleEffectObject.GetComponent<ParticleSystem>();
           // particleEffect.Play();

            //if (particleEffectObject == null)
           // {
                
            //}

            //particleEffect = gameObject.GetComponentInChildren<ParticleSystem>();

           // StartCoroutine(WaitToDestroy());
       // }
    }

   // public IEnumerator WaitToDestroy()
   // {
       // yield return new WaitForSeconds(.5f);
       // Destroy(this.gameObject);

  //  }
}
