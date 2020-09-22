using System.Collections;
using UnityEngine;

public class Player2Movement : MonoBehaviour
{
    public float Speed;
    public float Movement;
    
    public void Update() {
        Movement = Input.GetAxisRaw("VerticalA") * Speed;
        Vector3 toAdd = new Vector3(0, Movement, 0);
        GetComponent<Transform>().position += toAdd;
    }
}