using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class afisarepunctaj : MonoBehaviour
{
    private int punctaj;
    public Text scoreText;
    void Start()
    {
        punctaj = ifno.puncte;
        scoreText.text = punctaj.ToString();

    }
    
}
