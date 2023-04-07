using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartScript : MonoBehaviour
{
    public void RestartButton() {

        SceneManager.LoadScene("SampleScene");
    }
}
