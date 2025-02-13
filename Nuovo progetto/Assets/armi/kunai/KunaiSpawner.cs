using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class KunaiSpawner : MonoBehaviour
{
//l'assets del proiettile 
[SerializeField]
     private GameObject proiettile;
   //il punto da dove inizio a sparare
   [SerializeField]
    private Transform firepoint; 
    //L'azione che fa l'utente per sparare 
    [SerializeField]
    private InputActionReference shootAction;
    // Start is called before the first frame update
    /*
    
    */    


    // Update is called once per frame
    void Update()
    {
        /*shootAction.action.WasPressedThisFrame() =>
        se ho premuto in questo frame da come valore zero 
        altrimenti da come valore falso 
        */
      if (shootAction.action.WasPressedThisFrame()){
         
        /*instatiate => crea 
        Crea proiettile nella posizione firePoint.position, con rotazione
        firePoint.rotation
        */
        Instantiate(proiettile, firepoint.position, firepoint.rotation);
      }
    }

}