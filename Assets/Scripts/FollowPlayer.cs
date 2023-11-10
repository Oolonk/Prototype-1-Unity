using UnityEngine;


public class FollowPlayer : MonoBehaviour
{
    //Aufrufen eines GameObjektes
    public GameObject player;

    //Der Offset von der Kamera
    private Vector3 cameraOffset = new Vector3(0, 5, -7);

    // Aufgerufen während der Initialisierung
    void Start()
    {
    }

    // Spätere Hierarchie wann es ausgeführt werden soll von Update()
    void LateUpdate()
    {
        transform.position = player.transform.position + cameraOffset;
    }
}