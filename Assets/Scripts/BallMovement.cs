using System.Collections;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public void Start() {
        GetComponent<Rigidbody2D>().velocity = transform.right * 50f;
    }

    public void OnTriggerEnter2D(Collider2D col) {
        GetComponent<Rigidbody2D>().velocity = transform.right * 50f;
        Vector3 toSet = new Vector3(0, 0, GetZ());
        transform.localEulerAngles = toSet;
    }

    public float GetZ() {
	float returnVal = Random.Range(-25, 26);
	if (returnVal < 10 && returnVal > -25) {
	    returnVal -= 15;
	} else if (returnVal > 10 && returnVal < 15) {
	    returnVal += 15;
	}
	return returnVal;
    }
}