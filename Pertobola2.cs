using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pertobola2 : MonoBehaviour
{
   
   
   public static bool perto =false;
   
     void Update()
    {
     GameObject GOB = GameObject.Find("boladefogoa");
       if(Vector3.Distance(transform.position,GOB.transform.position)<10 && GOB!=null){
          perto=true; 
          GOB.transform.rotation = Quaternion.Slerp(GOB.transform.rotation, Quaternion.LookRotation(transform.position-GOB.transform.position),2*Time.deltaTime);
          GOB.transform.Translate(0,0,4*Time.deltaTime); 
          
        }
       
       
    } 
    
}

