using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    public Rigidbody rb; 

    public float force = 2000f; 
    public float sideF = 2000f; 

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, force * Time.deltaTime); 

        if(Input.GetKey("d"))
        {
            rb.AddForce(sideF * Time.deltaTime, 0, 0, ForceMode.VelocityChange); 
        }

        if(Input.GetKey("a"))
        {
            rb.AddForce(-sideF * Time.deltaTime, 0, 0, ForceMode.VelocityChange); 
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame(); 
        }
    }
}
