using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTP : MonoBehaviour
{
    public CharacterController player;
    public Vector3 destination;
    public Vector3 Playerposition;
    // Start is called before the first frame update
    void Start()
    {
        Playerposition = player.transform.position;
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Input1")
        {
            //debug
            Debug.Log("Triggered!");
            destination = new Vector3(-20, 0, 0);

            player.Move(destination);
        }
        if (other.tag == "Output1")
        {
            //debug
            Debug.Log("Triggered!");
            destination = new Vector3(20, 0, 0);

            player.Move(destination);
        }
      

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
