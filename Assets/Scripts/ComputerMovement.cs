using UnityEngine;

public class ComputerMovement : MonoBehaviour
{        

    public void FixedUpdate() {
        if (GameObject.FindWithTag("Ball").transform.position.y < transform.position.y) {
            Vector3 abc = transform.position - GameObject.FindWithTag("Ball").transform.position;
            abc.x = 0;
            abc.z = -89.7f;
            abc = Vector3.Normalize(abc);
            float yVelocity = GameObject.FindWithTag("Ball").GetComponent<Rigidbody2D>().velocity.y;
            abc *= (yVelocity * Random.Range(0.9f, 1.1f));
            GetComponent<Rigidbody2D>().velocity = abc;
        }
        else if (GameObject.FindWithTag("Ball").transform.position.y > transform.position.y) {
            Vector3 abc = GameObject.FindWithTag("Ball").transform.position - transform.position;
            abc.x = 0;
            abc.z = -89.7f;
            abc = Vector3.Normalize(abc);
            float yVelocity = GameObject.FindWithTag("Ball").GetComponent<Rigidbody2D>().velocity.y;
            abc *= (yVelocity * Random.Range(1f, 1.25f));
            GetComponent<Rigidbody2D>().velocity = abc;
        }
    }
}