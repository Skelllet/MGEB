using UnityEngine;

public class RotationMoney : MonoBehaviour
{
    public float rotSpeed = 1.0f;
    void Update()
    {
        transform.rotation = transform.rotation * Quaternion.Euler(0, rotSpeed, 0);
    }
}
