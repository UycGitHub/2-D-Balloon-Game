using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombaOlusturucu : MonoBehaviour
{
    public GameObject bomba;
    float bombaOlusturmaSuresi = 3.5f;
    float bombaZamanSayaci = 0;
    OyunKontrol okkSScripti1;


    void Start()
    {
        okkSScripti1 = this.gameObject.GetComponent<OyunKontrol>();
    }

   
    void Update()
    {
        bombaZamanSayaci -= Time.deltaTime;
        if (bombaZamanSayaci < 0) {
            GameObject goBomb = Instantiate(bomba, new Vector3(Random.Range(-2.3f,2.3f), -6f, 0), Quaternion.Euler(0, 0, 0)) as GameObject;
            goBomb.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, 80f, 0));
            bombaZamanSayaci = bombaOlusturmaSuresi;

        }
    }
}
