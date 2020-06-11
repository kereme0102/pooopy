using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public AudioClip[] sesDosyalari;  //Ses dosyaları için bir dizi oluşturduk
    public float hiz;  // sincapın yukarıya çıkması için hız adında bir değişken oluşturduk

    public float ziplamaGucu; // sincapın w ile hareket etmesini için gerekli değişken

    public float sağ; //sincapın sağa gitmesi için gerekli değişkeni tanımladık

    public float sol;   // sincapın sola  hareket etmesini için gerekli değişken
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * hiz * Time.deltaTime);     // oyun başlayınca verdiğimiz hız direk aktif olacak

        if (Input.GetKeyDown(KeyCode.W)) // eğer w tuşuna basılırsa

        {
            GetComponent<Rigidbody2D>().AddForce(Vector3.up * ziplamaGucu);  // up yani yukarıya hareket et
        }

        if (Input.GetKeyDown(KeyCode.A))  // eğer a tuşuna basılırsa

        {
            GetComponent<Rigidbody2D>().AddForce(Vector3.left * sol);  // sola hareket et


        if (Input.GetKeyDown(KeyCode.D))  // eğer d tuşuna basılırsa

        {
            GetComponent<Rigidbody2D>().AddForce(Vector3.right * sağ);  // sağa hareket et
        }



    }

    void OnCollisionEnter2D(Collision2D temas)  // temas adında bir colisio oluşturduk

    {
        if (temas.gameObject.tag == "puan") // eğer tag'i puan olan bir game objecte çarparsa
        {

        }
        else if (temas.gameObject.tag == "fındık") // eğer tag'i fındık olan bir game objecte çarparsa
        {
            GetComponent<AudioSource>().PlayOneShot(sesDosyalari[2], 1);  //ses dosyasındaki 2'ıncı elementi çalıştır
        }
        else
        {
            GetComponent<AudioSource>().PlayOneShot(sesDosyalari[0], 1); //ses dosyasındaki 0'ıncı elementi çalıştır

        }
    }

    }
}



