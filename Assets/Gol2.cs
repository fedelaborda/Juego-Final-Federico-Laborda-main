using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gol2 : MonoBehaviour
{
    public int golAzul;
    public GameObject player1;
    public GameObject player2;
    public GameObject ArcoAzul;
    public GameObject confetiAzul;
    public GameObject panel2;
    public Text ContadorAzul;
    public Text ContadorRojo;

    public float TimeToDestroy = 3f;

    // Start is called before the first frame update
    int cero = 0;
    void Start()
    {
        golAzul = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.name == "ArcoAzul")
        {
            transform.position = new Vector3(0, 0.57f, 0);
            player1.transform.position = new Vector3(0, 0.5f, -10);
            player1.transform.eulerAngles = new Vector3(0, 0, 0);
            player2.transform.position = new Vector3(0, 0.5f, 10);
            player2.transform.eulerAngles = new Vector3(0, 180, 0);

            golAzul ++;
            ContadorAzul.text = golAzul.ToString();

            for (int i = 0; i < 10; i++)
            {
                Instantiate(confetiAzul);

                TimeToDestroy -= Time.deltaTime;
                
                if(TimeToDestroy <= 0)
                {
                    Destroy(confetiAzul);
                }
            }

            if (golAzul >= 3)
            {
                panel2.SetActive(true);
                ContadorAzul.text = cero.ToString();
                ContadorRojo.text = cero.ToString();
            }

        }

    }

}
