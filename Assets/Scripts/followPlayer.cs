
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Transform Player1;
    public Vector3 offset;

    void Update()
    {
        transform.position = Player1.position + offset;
    }
}