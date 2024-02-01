using UnityEngine;

public class PlayerCollision : MonoBehaviour{

    public PlayerOneMov movement;

    
    void OnCollisionEnter(Collision collInfo)
    {

        if (collInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;

            FindObjectOfType<GameManager>().EndGame();

        }

    }

}