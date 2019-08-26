using UnityEngine;
using System.Collections;

public class JumpPlat2D : MonoBehaviour {

	public float jumpHeight = 500;
	float VelY;

    private Rigidbody2D body;
    void Start () {
        body = GameObject.FindGameObjectWithTag ("Player").GetComponent<Rigidbody2D> ();
    }
	// Update is called once per frame
	void Update () {
		VelY = body.velocity.y;
	
	}
	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "JumpPlat" && VelY <= 0)
		{
			body.velocity = new Vector2(0,0);
			body.AddForce(new Vector2(0,jumpHeight));
		}
}
}
