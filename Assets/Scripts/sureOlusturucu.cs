using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sureOlusturucu : MonoBehaviour

    
{
    public GameObject nSure;
    float nSureOlusturmaSuresi = 5f;
    float nZamanSayaci = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        nZamanSayaci -= Time.deltaTime;
        if (nZamanSayaci < 0)
        {
            GameObject goNSure = Instantiate(nSure, new Vector3(Random.Range(-1.8f, 1.8f), -6f, 0), Quaternion.Euler(0, 0, 0)) as GameObject;
            goNSure.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, 60f, 0));
            nZamanSayaci = nSureOlusturmaSuresi;

        }

    }
}
