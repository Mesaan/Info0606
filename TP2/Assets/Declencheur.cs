using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Declencheur : MonoBehaviour
{
    private int score;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /* Afin de gérer le compteur de cubes, on a augmenté
    * la hauteur de la zone de détection (on oblige donc l
    * cube à être relativement centré sur la plateforme)
    */
    private void OnTriggerEnter(Collider other)
    {
        score+=1; //A chaque entrée dans la zone on augmente le compteur
        Debug.Log("Score : "+score);
    }

    private void OnTriggerExit(Collider other)
    {
        score-=1; //Et on le décrémente à chaque sortie de zone
        Debug.Log("Score : "+score);
    }
}
