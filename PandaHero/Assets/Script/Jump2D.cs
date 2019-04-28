using UnityEngine;
using System.Collections;

public class Jump2D : MonoBehaviour {

	public bool grounded; 
	public float jumpHeight = 500f;

	public Transform groundcheck;

	public float groundRadius = .2f;
	public LayerMask ground;
    private Rigidbody2D body;
    void Start () {
        body = this.gameObject.GetComponent<Rigidbody2D> ();
    }
	void FixedUpdate ()
	{
		grounded = Physics2D.OverlapCircle(groundcheck.position,groundRadius,ground);
		float vely = body.velocity.y;
		if(grounded && vely <=0 ){

			body.velocity = new Vector2(0,0);
			body.AddForce(new Vector2(0,jumpHeight));
	}
									}
}
