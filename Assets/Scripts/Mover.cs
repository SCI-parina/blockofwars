using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

    public float MoveSpeed = 0f;
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(transform.position.x +( MoveSpeed* Time.deltaTime), transform.position.y, transform.position.z);
	}

    void OnCollisionEnter2D(Collision2D other) {
        print(other.gameObject);
        if (other.gameObject.GetComponent<Team>() == null) {
            Destroy(other.gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other) {
        print(other);
    }
}
