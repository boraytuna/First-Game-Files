using UnityEngine;

public class PlayerOneMov : MonoBehaviour
{

    public Rigidbody rb;

    public float Fforce = 2000f;
    public float Sforce = 1000f;
    public float Rforce = 500f;


    void FixedUpdate()
    {
        Fforce = 0f;

            if (Input.GetKey("w"))
            {
                Fforce = 2000f;
                rb.AddForce(0, 0, Fforce * Time.deltaTime);
            }

            if (Input.GetKey("s"))
            {
                rb.AddForce(0, 0, -Rforce * Time.deltaTime, ForceMode.VelocityChange);
            }

            if (Input.GetKey("d"))
            {
                rb.AddForce(Sforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }

            if (Input.GetKey("a"))
            {
                rb.AddForce(-Sforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }

            if (rb.position.y < -1f)
            {
                FindObjectOfType<GameManager>().EndGame();
            }

        
    }
}