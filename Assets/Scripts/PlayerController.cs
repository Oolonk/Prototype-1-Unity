using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Move the vehicle forward
        transform.Translate(Vector3.forward * (Time.deltaTime * 20));
    }

    //Update is called every fixed value
    private void FixedUpdate()
    {

    }
}
