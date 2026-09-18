using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Rigidbody ball;
    public float force = 1f;
    public TMP_Text score;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        score.text = ball.position.z.ToString("0");
     ball.AddForce(0f,0f,force);

    if (Keyboard.current != null && Keyboard.current.aKey.isPressed)
     ball.AddForce(-force,0f,0f);

     if (Keyboard.current != null && Keyboard.current.dKey.isPressed)
     ball.AddForce(force,0f,0f); 

     if (Keyboard.current != null && Keyboard.current.sKey.isPressed)
     force = force * -1f;

    if (ball.position.y<-5)
    SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);

    }
}
