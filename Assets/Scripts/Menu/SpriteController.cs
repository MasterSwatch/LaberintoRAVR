using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // no olvidar nunca las librerias que se usan en cada script

public class SpriteController : MonoBehaviour
{
    public GameObject Pausa; // variable para GameObject
    public Sprite pauseSprite;
    public Sprite playSprite;
    void Start()
    {
        Pausa = gameObject;
        // acción
        Sprite Load(string imageName, string spriteName) //
        {
            Sprite[] all = Resources.LoadAll<Sprite>(imageName); // es para leer todos los sprites que vayan apareciendo en carpeta
            foreach (var s in all) // 
            {
                if (s.name == spriteName) // 
                {
                    return s;
                }
            }
            return null;
        }
        // a quién se le hace la acción

        playSprite = Load("play-pause", "Play"); // sprite de play
        pauseSprite = Load("play-pause", "Pausa"); // sprite de pausa


    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 0)
        {
            Pausa.GetComponent<Image>().sprite = playSprite;
        }
        else
        {
            Pausa.GetComponent<Image>().sprite = pauseSprite;
        }
    }
}
