using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    bool chasingPlayer = true;
    public Transform player;
    public speed = 1;
    public float pushForce = 1;
    Rigidbody rig;

    // Start is called before the first frame update
    void Start()
    {
     rig = GetComponent<Rigidbody>()
    }

    // Update is called once per frame
    void Update()
    {
        
      if (chasingPlayer)
      {
          transform. LookAt(player.position, ); 
          rig.velocity = transform.forward * speed + new Vector3(0, 0, rig.velocity.z)  
    }
}
private void OnTriggerEnter(Collider other)
{
    if(other.gameObejct.tag == "Player")
    {
        Rigidbody PlayerRig = collision.gameObject.GetComponent<Rigidbody>();
        playerRig.velocity = transform.forward * pushdorce * new Vector3(0, 0, player.velocity.z)
        chasigPlayer = true;
    }
}

private void OnTriggerEnter(Collider other)
{
    if(other.gameObejct.tag == "Player")
    {
        chasigPlayer = false;
    }
}
   
   void OnCollisionEnter(Collision collision)
   
   {
       if (collision.gameObject.tag == "Player")
       {
           Destroy(collicion.gameObejct.tag == "Player")
           
       }
       
       audioSource.Play();
    }

