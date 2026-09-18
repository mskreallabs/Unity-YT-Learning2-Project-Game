using UnityEngine;

public class CameraControl : MonoBehaviour
{   public Transform ballPosition;
    public Vector3 postion;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = ballPosition.position - postion;
    }
}
