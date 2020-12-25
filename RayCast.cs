using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
   public Camera Playercamera;
   public float FireRate = 10f;
   public float timeBetweenNextShot;
   public float Damage = 20f;


   void Update(){
       if(Input.GetButton("Fire1")&& Time.time >= timeBetweenNextShot){
           timeBetweenNextShot = Time.time + 1f/FireRate;
        weapon();
       }
   }
   void weapon(){
   RaycastHit hit;
   if(Physics.Raycast(Playercamera.transform.position , Playercamera.transform.forward,out hit )){
       Health enemy = hit.transform.GetComponent<Health>();
 enemy.Damage(Damage);
   }
   }
}
