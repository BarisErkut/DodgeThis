using Unity.VisualScripting;
using UnityEngine;

public class DropTimer : MonoBehaviour
{
    [SerializeField] public float dropTimer = 3.0f;

    MeshRenderer meshRenderer;
    Rigidbody rigidBody;
    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();

        meshRenderer.enabled = false;
        rigidBody.useGravity = false; 
    }
    void Update()
    {
        if(Time.time >= dropTimer)
        {
            meshRenderer.enabled = true;
            rigidBody.useGravity=true;
        }
        
    }
}
