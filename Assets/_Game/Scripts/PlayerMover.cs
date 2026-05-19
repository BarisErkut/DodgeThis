using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private bool isAlive = true;
    [SerializeField] public float moveSpeed = 5f;
    [SerializeField] private int playerHealth = 100;

    void Start()
    {
        
    }
    void Update()
    {
        float xSpeed = (Input.GetAxis("Horizontal") * moveSpeed) * Time.deltaTime ;
        float ySpeed = 0f * Time.deltaTime;
        float zSpeed = (Input.GetAxis("Vertical") * moveSpeed)* Time.deltaTime ;
        transform.Translate(xSpeed, ySpeed, zSpeed);
    }
}
