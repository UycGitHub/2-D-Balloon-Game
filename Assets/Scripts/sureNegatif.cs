using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sureNegatif : MonoBehaviour
{
    public GameObject sureNItem;

    void Start()
    {
        Vector3 pos = new Vector3(0, 0, 0);
        Quaternion q = new Quaternion (0, 0, 0,0);

        Instantiate(sureNItem, pos, q); 
    }

   
    void Update()
    {
        
    }
}
