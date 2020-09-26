using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
 
public class Empurra: MonoBehaviourPun
{
   float grandeEmpurro = 2.0f;
   Vector3 direcaoEmpurro; 
 void OnControllerColliderHit(ControllerColliderHit hit){
   Rigidbody bodyEmpurrado = hit.collider.attachedRigidbody;
   if(bodyEmpurrado ==null || bodyEmpurrado.isKinematic)
    return;
   if(hit.moveDirection.y <-0.3f)
    return;
    direcaoEmpurro = new Vector3 (hit.moveDirection.x,0,hit.moveDirection.z);
   bodyEmpurrado.velocity = direcaoEmpurro*grandeEmpurro;
 }
   
  
}
