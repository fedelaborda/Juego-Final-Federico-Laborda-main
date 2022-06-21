using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Contador : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    public GameObject pelota;
    public GameObject confetiRojo;
    public GameObject confetiAzul;

    public Text ContadorRojo;
    public Text ContadorAzul;

    public float TimeToFinish = 10f;
    public Text ContadorText;
    public int TiempoToText;

    public int golRojo;
    public int golAzul;

    // Start is called before the first frame update

    void Start()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Finish")
        {
            golRojo++;
        }

        if (col.gameObject.name == "ArcoAzul")
        {
            golAzul++;
        }

    }

    public void LoadScene(string sceneToLoad)
    {
        SceneManager.LoadScene(sceneToLoad);
    }
    // Update is called once per frame

    void Update()
    {
        TimeToFinish -= Time.deltaTime;
        TiempoToText = (int)TimeToFinish;
        ContadorText.text = TiempoToText.ToString();


        if (TimeToFinish <= 0 && golRojo > golAzul)
        {
            
        }

        if (TimeToFinish <= 0 && golRojo < golAzul)
        {

        }

        if (TimeToFinish <= 0 && golRojo == golAzul)
        {

        }

        //txt_time.text = Time.time.ToString();
    }
    //public void RestartGame()
    //{
        //transform.position = new Vector3(0, 0.57f, 0);
        //player1.transform.position = new Vector3(0, 0.5f, -10);
        //player1.transform.eulerAngles = new Vector3(0, 0, 0);
        //player2.transform.position = new Vector3(0, 0.5f, 10);
        //player2.transform.eulerAngles = new Vector3(0, 180, 0);
        //pelota.transform.position = new Vector3(0, 0.57f, 0);
        //TimeToFinish = 30f;
         
    //}
}
