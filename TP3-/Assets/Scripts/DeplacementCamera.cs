using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeplacementCamera : MonoBehaviour
{
    public Transform globe; //On récupère l'objet globe
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //Pour chaque input, on récupère le sens et on tourne en fonction.
        //Utilisation de RotateAround pour avoir comme point de référence le globe.
        //On a mis une plus grande vitesse pour aller à gauche et à droite afin
        //D'améliorer la fluidité d'opération côté utilisateur.
        
       if (Input.GetKey(KeyCode.LeftArrow))
        {
        transform.RotateAround(globe.position,Vector3.up, 10f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
        transform.RotateAround(globe.position,Vector3.down, 10f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
        transform.RotateAround(globe.position,Vector3.right, 4f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
        transform.RotateAround(globe.position,Vector3.left, 4f * Time.deltaTime);
        }

    }
}
