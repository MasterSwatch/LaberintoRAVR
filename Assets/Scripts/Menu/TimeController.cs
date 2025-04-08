using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeController : MonoBehaviour
{
    public GameObject menuPausa;
    public float scaleAtRuntime;

    public void HandleTime() //controlador de escala de tiempo
    {
        if (Time.timeScale != 0)
        {
            Pause();
        }
        else
        {
            Resume();
        }
    }

    public void Pause() // para que active la pausa verdaderamente y pare el juego
    {
        scaleAtRuntime = Time.timeScale;
        Time.timeScale = 0;
        menuPausa.SetActive(true);
    }

    public void Resume() // para que retome el juego después de la pausa
    {
        Time.timeScale = scaleAtRuntime;
        menuPausa.SetActive(false);
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
