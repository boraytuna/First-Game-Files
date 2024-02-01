using UnityEngine.UI;
using UnityEngine;

public class Scoreboard : MonoBehaviour
{
    public Transform PlayerOne;
    public Text textScore;

    void Update()
    {
        textScore.text = PlayerOne.position.z.ToString("0");
    }
}
