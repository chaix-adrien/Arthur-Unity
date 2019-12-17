using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockCamera : MonoBehaviour
{
    public Transform aSuivre;
     public int vitesseRotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

void checkRotation()
  {
    if (Input.GetKey("left"))
    {
     transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y - Time.deltaTime * vitesseRotation, transform.eulerAngles.z);
    }
    if (Input.GetKey("right"))
    {
     transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y + Time.deltaTime * vitesseRotation, transform.eulerAngles.z);
    }
  }

    // Update is called once per frame
    void Update()
    {
        //La position de la caméra = la position aSuivre
        transform.position = aSuivre.position;
        this.checkRotation();
    }
}
