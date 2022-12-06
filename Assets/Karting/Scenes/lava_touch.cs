using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using KartGame.KartSystems;
using TMPro;

public class lava_touch : MonoBehaviour
{
    public ArcadeKart KartController;

    // Start is called before the first frame update
      void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision other)
    {
        SceneManager.LoadScene("LoseScene");
    }
}
