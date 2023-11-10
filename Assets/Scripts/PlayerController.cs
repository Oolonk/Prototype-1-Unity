using UnityEngine;
public class PlayerController : MonoBehaviour
{
    // Horizontale Geschwindigkeit vom Spieler
    private float horizontalInput;
    // Beschleunigung vom Spieler
    private float forwardInput;
    // Geschwindigkeit des Autos
    private float speed = 20.0f;
    //Drehgeschwindigkeit des Autos
    private float turnSpeed = 40.0f;
    // Aufgerufen während der Initialisierung
    void Start()
    {

    }

    // Wird jeden Frame abgerufen
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // Move the vehicle forward
        transform.Translate(Vector3.forward * (Time.deltaTime * speed * forwardInput));
        transform.Rotate(Vector3.up * (Time.deltaTime * turnSpeed * horizontalInput));
    }

    //Wird immer eine gefixte Anzahl an Zeit abgerufen
    private void FixedUpdate()
    {

    }
}
