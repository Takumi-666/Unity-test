using UnityEngine;

class Ball : MonoBehaviour
{
    public float speed = 5f;
    Rigidbody myRigidbody;

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        myRigidbody.velocity = new Vector3(speed, Random.Range(-speed, speed), 0f);
    }
}
