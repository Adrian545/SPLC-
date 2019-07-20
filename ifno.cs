using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ifno : MonoBehaviour
{
    public static int puncte;
    private float currentTime = 0;
    private float step = 0.1f;
    public void Wrong(int openscene)
    {
        puncte = puncte + 3;
        print(puncte);
        StartCoroutine(TimeRoutine());
        SceneManager.LoadScene(openscene);
    }
    IEnumerator TimeRoutine()
    {
        while (currentTime<5)
        {
            yield return new WaitForSeconds(step);
            currentTime += step;
        }
    }



}
