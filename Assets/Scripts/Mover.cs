using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

    public float MoveSpeed = 0f;
    public int team_id = 0;
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(transform.position.x +( MoveSpeed* Time.deltaTime), transform.position.y, transform.position.z);
	}

    void OnTriggerEnter2D(Collider2D other) {
        Mover block = other.gameObject.GetComponent<Mover>();
        if (block != null && block.team_id != team_id) {
            Destroy(other.gameObject);
        }
    }
}
