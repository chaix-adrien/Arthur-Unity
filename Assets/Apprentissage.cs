using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apprentissage : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {
    this.apprentissage();
  }

  int addition(int a, int b)
  {
    return a + b;
  }

  int multiplication(int a, int b)
  {
    return a * b;
  }

  int soustraction(int a, int b)
  {
    return a - b;
  }

  int division(int a, int b)
  {
    return a / b;
  }

  void apprentissage()
  {
    int compteur = 1;
    while (compteur < 11)
    {
      Debug.Log(compteur);
      Debug.Log(this.addition(compteur, compteur));
      Debug.Log(this.multiplication(compteur, compteur));
      Debug.Log(this.division(compteur, compteur));
      Debug.Log(this.soustraction(compteur, compteur));
      compteur = compteur + 1;
      Debug.Log("FIN DE LA BOUCLE");
    }
  }

  // Update is called once per frame
  void Update()
  {
  }
}
