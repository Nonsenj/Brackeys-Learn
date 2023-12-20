using UnityEngine;

public class PlayMovement : MonoBehaviour
{
    //this is a reference to the Rigidbody component called "rd"
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {

        //rb.useGravity = false; //Disable gravity object using useGraviy from Rigidbody component
        //rb.AddForce(20,200,500); //Add a force once when start using diraction vector3

    }

    // Update is called once per frame
    void Update()
    {
        //rb.AddForce(0,0,200); //Add a force every frame
        //rb.AddForce(0, 0, 2000 * Time.deltaTime); //Add a force every frame regard other computer

    }

    // "Fixed"Update using it to mess with physics
    private void FixedUpdate()
    {
        rb.AddForce(0, 0, 2000 * Time.deltaTime); //Add a force every frame regard other computer
    }
}
