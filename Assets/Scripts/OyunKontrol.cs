using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OyunKontrol : MonoBehaviour
{
    public UnityEngine.UI.Text zamanText, balonText;
    public GameObject patlama;
    public float zamanSayaci = 60f;
    
    int puan = 0;

    void Start()
    {
        balonText.text = "" + puan;
        
    }

    
    void Update()
    
    {
        
        if (zamanSayaci > 0)
        {
            zamanSayaci -= Time.deltaTime;
            zamanText.text = "" + (int)zamanSayaci;
        }
        else {
            GameObject[] go = GameObject.FindGameObjectsWithTag("balon");
            for (int i = 0; i < go.Length; i++) {
                Instantiate(patlama, go[i].transform.position,go[i].transform.rotation);
                Destroy(go[i]);

                SceneManager.LoadScene("finalSahnesi");

            }
        }

        


    }
    public void BalonEkle() {

        puan += 3;
        balonText.text = "" + puan;


    }
    
    public void bombaEkle()
    {

        puan -= 10;
        balonText.text = "" + puan;

    }

   
}

