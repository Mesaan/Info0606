using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouvement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
        transform.Translate(Vector3.forward * 0.01f);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            /*
            * Afin de faire sprinter le joueur, il suffit
            * de vérifier lorsque la touche "avancer" est
            * pressée, si celle de sprint (ici shift) est
            * également pressée, et mettre un coefficient
            * de rapidité plus important.
            */
            if (Input.GetKey(KeyCode.LeftShift))
            {
            transform.Translate(Vector3.back * 0.03f);
            } else{
                //La fonction de marche normale va donc dans le else
            transform.Translate(Vector3.back * 0.01f);
            }
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
        transform.Rotate(Vector3.up, -0.5f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
        transform.Rotate(Vector3.up, 0.5f);
        }
        /*
        * Afin d'ajouter la possibilité de faire sauter le
        * personnage, on ajoute simplement un nouveau
        * comportement lorsque la barre espace est pressée.
        */ 
        if (Input.GetKey(KeyCode.Space))
        {
        transform.Translate(Vector3.up * 0.02f);
        }
    }
}
