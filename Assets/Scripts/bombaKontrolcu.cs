using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombaKontrolcu : MonoBehaviour
{
    public GameObject bombaPatlama;
    OyunKontrol OyunKontrolScipti1;
    void Start()
    {

        OyunKontrolScipti1 = GameObject.Find("_Scripts").GetComponent<OyunKontrol>();
    }
    public void OnMouseDown()
    {
        GameObject bombaGo = Instantiate(bombaPatlama, transform.position, transform.rotation) as GameObject;
        Destroy(this.gameObject);
       
        Destroy(bombaGo, 0.50f);
        OyunKontrolScipti1.bombaEkle();
    }
}
