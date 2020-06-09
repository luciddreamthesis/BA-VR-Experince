using UnityEngine;
using System.Collections;

public class PlayerFlyingScript : MonoBehaviour {
    Rigidbody ourOneironaut;
    void Awake(){
        ourOneironaut = GetComponent<Rigidbody>();
    }
    public float speed = 1;
    public float position = 0;
    void FixedUpdate(){
        
        if(Input.GetKey(KeyCode.K)) {
            Vector3 move = new Vector3(0, position++, 0) * speed;
            ourOneironaut.MovePosition(move);
        }

    }

    


}
