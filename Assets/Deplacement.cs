using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deplacement : MonoBehaviour
{
  // Start is called before the first frame update

  private Rigidbody rb;

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
    if (Input.GetKey("q"))
    {
      rb.velocity = rb.velocity + new Vector3(-1, 0, 0) * vitesse * Time.deltaTime;
    }
    if (Input.GetKey("d"))
    {
      rb.velocity = rb.velocity + new Vector3(1, 0, 0) * vitesse * Time.deltaTime;
    }
    if (Input.GetKey("z"))
    {
      rb.velocity = rb.velocity + new Vector3(0, 0, 1) * vitesse * Time.deltaTime;
    }
    if (Input.GetKey("s"))
    {
      rb.velocity = rb.velocity + new Vector3(0, 0, -1) * vitesse * Time.deltaTime;
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