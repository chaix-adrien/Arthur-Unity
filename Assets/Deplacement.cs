using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deplacement : MonoBehaviour
{
  // Start is called before the first frame update

  private Rigidbody rb;
  public Transform camera;
  public int vitesse;
  public int vie;

  void Start()
  {
    rb = GetComponent<Rigidbody>();
  }

  void checkKey()
  {
    if (Input.GetKeyDown("space"))
    {
      rb.velocity = rb.velocity + new Vector3(0, 1, 0) * vitesse;
    }
    if (Input.GetKey("z")) {
      //La direction de la vitesse  = la direction de la caméra (en avant)
      rb.velocity = rb.velocity + camera.forward  * vitesse * Time.deltaTime;
    }
    if (Input.GetKey("s")) {
      //La direction de la vitesse  = l'inverse de la direction de la caméra (en arriere)
      rb.velocity = rb.velocity +  -camera.forward * vitesse * Time.deltaTime;
    }
    if (Input.GetKey("d")) {
      //La direction de la vitesse = la droite de la caméra (a droite)
      rb.velocity = rb.velocity + camera.right * vitesse * Time.deltaTime;
    }
    if (Input.GetKey("q")) {
      //La direction de la vitesse = l'inverse de la droite de la caméra (a gauche)
      rb.velocity = rb.velocity +  -camera.right * vitesse * Time.deltaTime;
    }    
  }


  void checkPosition()
  {
    if (transform.position.y < -1)
    {
      this.vie = this.vie - 1;
      transform.position = new Vector3(0, 2, 0);
    }
  }

  void Update()
  {
    this.checkKey();
    this.checkPosition();

  }
}