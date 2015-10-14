using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

    public float MoveSpeed = 1f;
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(transform.position.x +( MoveSpeed* Time.deltaTime), transform.position.y, transform.position.z);
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(other.gameObject);
    }
}
