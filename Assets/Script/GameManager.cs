using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject[] spawnObject;
    public GameObject[] spawnPoints;

    public float timer;
    public float timeBetweenSpawns;
    public Text distanceUI;
    public float speedMultiplier;
    public static float distance;
    public string bukaScene;
    public float cekSkorScene;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(timer);

        distanceUI.text = "0" + distance.ToString("F2");
        speedMultiplier += Time.deltaTime * 0.1f;

       timer += Time.deltaTime;

       distance += Time.deltaTime * 0.8f;

      if (distance >= cekSkorScene)
      {
        SceneManager.LoadScene(bukaScene);
      }
    }
    
}
