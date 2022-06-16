using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gol : MonoBehaviour
{

    public int golRojo;
    public GameObject player1;
    public GameObject player2;
    public GameObject ArcoRojo;
    public GameObject confetiRojo;
    public GameObject panel1;
    public Text ContadorRojo;
    public Text ContadorAzul;
    AudioSource hinchada;
    AudioSource gritoGol;
    public float TimeToDestroy = 3f;

    // Start is called before the first frame update

    int cero = 0;
    void Start()
    {
        golRojo = 0;
        hinchada = GetComponent<AudioSource>();
        gritoGol = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.tag == "Finish")
        {
            transform.position = new Vector3(0, 0.57f, 0);
            player1.transform.position = new Vector3(0, 0.5f, -10);
            player1.transform.eulerAngles = new Vector3(0, 0, 0);
            player2.transform.position = new Vector3(0, 0.5f, 10);
            player2.transform.eulerAngles = new Vector3(0, 180, 0);

            golRojo ++;

            ContadorRojo.text = golRojo.ToString();

            for (int i = 0; i < 10; i++)
            {
                Instantiate(confetiRojo);

                TimeToDestroy -= Time.deltaTime;

                if (TimeToDestroy <= 0)
                {
                    Destroy(confetiRojo);
                }
            }

            if (golRojo >= 3)
            {
                panel1.SetActive(true);
                ContadorRojo.text = cero.ToString();
                ContadorAzul.text = cero.ToString();
            }

        }

    }
}
