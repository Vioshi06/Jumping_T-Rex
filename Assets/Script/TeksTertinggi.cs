using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TeksTertinggi : MonoBehaviour
{

    public Text skorTertinggi;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int s = (int) GameManager.distance;
        skorTertinggi.text = "Skor: " + s.ToString();
    }
}
