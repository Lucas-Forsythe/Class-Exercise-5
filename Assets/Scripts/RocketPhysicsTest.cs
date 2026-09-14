using Unity.VisualScripting;
using UnityEngine;

public class RocketPhysicsTest : MonoBehaviour
{
    //Set rb to the rigidbody of the rocket
    Rigidbody rb;
    //Create thurst variable that can be changed in inspector
    [SerializeField] float thrust;
    [SerializeField] float rotationSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Get the rigidbody of the rocket
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ApplyThrust();
        RotateRocket();
    }

    //Applying thrust every frame
    void ApplyThrust()
    {
        //Apply force to the rigidbody in the direction of the rocket's y axis
        //Note that when rotating the rocket, the force will always be applied in the direction of the rocket's y axis
        rb.AddRelativeForce(Vector3.up * thrust);

        //While testing everything I think that a thrust of 5, a mass of 2, and a linear drag of 0 is what feels best to me.
        //Physic tuning is a part of game design because we want the game to feel good to the player. The rocket cannot be too heavy to move at a fast enough speed but must have weight to feel like a real object.
    }

    //Rotate the rocket around the y axis
    void RotateRocket()
    {
        transform.Rotate(0,1, 0 * rotationSpeed * Time.deltaTime);
    }


}
