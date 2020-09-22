using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed;
    public float Movement;

    public void Update() {
        Movement = Input.GetAxisRaw("Vertical") * Speed;
        Vector3 toAdd = new Vector3(0, Movement, 0);
        GetComponent<Transform>().position += toAdd;
    }
}