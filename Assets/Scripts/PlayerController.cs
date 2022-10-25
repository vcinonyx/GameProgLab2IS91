using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   [SerializeField] private float jump = 10f;
   [SerializeField] private float speed = 10f;
   [SerializeField] private Rigidbody rb;
   
   private void Start()
   {
      rb = GetComponent<Rigidbody>();
   }

   private void Update()
   {
      var horizontal = Input.GetAxis("Horizontal");
      var vertical = Input.GetAxis("Vertical");
      
      transform.Translate(horizontal * Time.deltaTime * speed, 0, vertical * Time.deltaTime * speed);
      
      JumpPlayer();
   }
   
   private void JumpPlayer()
   {
      if (Input.GetButtonDown("Jump"))
      {
         rb.AddForce(Vector3.up * jump, ForceMode.VelocityChange);
      }
   }
   
}