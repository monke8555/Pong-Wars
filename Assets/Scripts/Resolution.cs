using UnityEngine;

public class Resolution : MonoBehaviour
{
    public void Update() {
        Screen.SetResolution(728, 512, false);
    }
}