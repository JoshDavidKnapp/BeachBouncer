using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterSec : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DestroyAfter());
    }

    // Update is called once per frame
    void Update()
    {
        if(this.gameObject.activeInHierarchy)
        {
            StartCoroutine(DestroyAfter());
        }
    }

    public IEnumerator DestroyAfter()
    {
        yield return new WaitForSeconds(3);
        this.gameObject.SetActive(false);
        

        
    }
}
