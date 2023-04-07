using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalonKontrolcu : MonoBehaviour
{
    public GameObject patlama;
    OyunKontrol OyunKontrolScipti;
    

    void Start() {

        OyunKontrolScipti = GameObject.Find("_Scripts").GetComponent<OyunKontrol>();
    }
     void OnMouseDown()
    {
        GameObject go = Instantiate(patlama, transform.position,transform.rotation) as GameObject;
        Destroy(this.gameObject);
       
        Destroy(go, 0.517f);
         OyunKontrolScipti.BalonEkle();


      
    }

}
