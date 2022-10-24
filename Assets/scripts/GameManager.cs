using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject gameOverCanvas;
    [SerializeField] Player player;

    float timer = 0f;
    


    // Start is called before the first frame update
    void Start()
    {
        gameOverCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        int animales = GameObject.FindGameObjectsWithTag("animal").Length;
        if (animales < 1)
        {
            player.paused = true;
            gameOverCanvas.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void ResetGame()
    {
        SceneManager.LoadScene(0);
    }
}
