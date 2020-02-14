using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimenti : MonoBehaviour
{
    [SerializeField]
    float speed = 1;

    // Update is called once per frame sos
    void Update()
    {
        float movimentoVericale = Input.GetAxis("Vertical");
        float movimentoOrizzontale = Input.GetAxis("Horizontal");
        Vector3 direzione = new Vector3(0, 0, 0);

        //se premo il tasto muovi il personaggio l'ungo l'asse corrispondente
        if (movimentoOrizzontale != 0)
        {
            direzione.x = movimentoOrizzontale;
        }
        if(movimentoVericale != 0)
        {
            direzione.y = movimentoVericale;
        }
        transform.Translate(direzione * (speed * Time.deltaTime));
    }
}
