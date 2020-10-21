using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float speedMultiplier = 1f;
   
	private Rigidbody _rigidbody; //Rigidbody attached to the gameobject
    private float _movementHorizontal;
    private float _movementVertical; //Input values



    // Awake is called when it is instantiated
    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
		_rigidbody = transform.GetComponent<Rigidbody>();
    }

    // Update is called once per frame

    void Update()
	{


	}

    // FixedUpdate is called 60 times in seconds

    private void FixedUpdate()
	{
        if (Input.GetKeyDown(KeyCode.Space))

         _rigidbody.AddForce(x: 0, y: 1f, z: 0, ForceMode.Impulse);

        _movementHorizontal = Input.GetAxis("Horizontal") * speedMultiplier;
        _movementVertical = Input.GetAxis("Vertical") * speedMultiplier;
		_rigidbody.AddForce( x: _movementHorizontal, y: 0, z: _movementVertical, ForceMode.Acceleration);


	}
    private void OnCollisionEnter(Collision other)

    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //Collect and Destroy Coin
        if (other.transform.CompareTag("Coin"))
         GameObject.Destroy(other.gameObject);

        // Add Coins to Score
        // Gain Health in 100 Coins
    }
}
