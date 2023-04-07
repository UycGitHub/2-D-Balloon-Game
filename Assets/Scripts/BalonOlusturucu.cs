using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalonOlusturucu : MonoBehaviour
{
    public GameObject balon;
    float balonOlusturmaSuresi = 0.5f;
    float zamanSayacý = 0f;
    OyunKontrol okSScripti;

    void Start()
    {
        okSScripti = this.gameObject.GetComponent<OyunKontrol>();
    }

    // Update is called once per frame
    void Update()
    {
        zamanSayacý -= Time.deltaTime;
        int katsayi = (int)(okSScripti.zamanSayaci / 10) - 9;
        katsayi *= -1;

        if (zamanSayacý < 0 && okSScripti.zamanSayaci >0) {
            GameObject go = Instantiate(balon, new Vector3(Random.Range(-2f,2.3f), -6f , 0), Quaternion.Euler(0, 0, 0)) as GameObject;
            go.GetComponent<Rigidbody2D>().AddForce(new Vector3(0,Random.Range(30f*katsayi,55f*katsayi),0));

            zamanSayacý = balonOlusturmaSuresi;
        }

        
    }
}
