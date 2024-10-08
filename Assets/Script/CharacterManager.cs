using UnityEngine;
using System.Collections;

public class CharacterManager : MonoBehaviour
{
		
		public float jumpHeight = 500f;
		public float speed = 2.0f;
		public float groundRadius = .2f;

		public bool grounded; 
		public Transform groundcheck;
		public LayerMask ground;

		private Rigidbody2D body;
		private Vector2 objPos;
		private	Vector2 touchpos;

		void Start ()
		{
				body = gameObject.GetComponent<Rigidbody2D> ();
		}

		void Update ()
		{
						//Left & Right Movement
						Touch touch = Input.GetTouch (0);
						touchpos = Camera.main.ScreenToWorldPoint (touch.position);
						body.velocity = new Vector2 (touchpos.x * speed, body.velocity.y);
		}
		void FixedUpdate () {
				//Jumping
				grounded = Physics2D.OverlapCircle(groundcheck.position,groundRadius,ground);
				float vely = body.velocity.y;
				if(grounded && vely <=0 ){

						body.velocity = new Vector2(0,0);
						body.AddForce(new Vector2(0,jumpHeight));
				}
				//WARP!
				if (transform.position.x <= -3.75f) {
						transform.position = new Vector3 (3.75f, transform.position.y, transform.position.z);
				} else if (transform.position.x >= 3.75) {
						transform.position = new Vector3 (-3.75f, transform.position.y, transform.position.z);
				}
		}
}
