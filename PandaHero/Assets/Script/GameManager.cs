using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour 
{
	public Transform player;
	float playerHeightY;

	public Transform regular;
	public Transform jump;
	public Transform LeftRight;
	public Transform UpDown;

	private int platNumber;

	private float platCheck;
	private float spawnPlatformsTo;
	// Use this for initialization
	void Start () 
	{
		player = GameObject.FindGameObjectWithTag("Player").transform;

		PlatformSpawner (3.5f);
	}
	
	// Update is called once per frame
	void Update () {
		playerHeightY = player.position.y;
		if(playerHeightY > platCheck)
		{
			PlatformManager();
		}
		float currentCameraHeight = transform.position.y;

		float newHeightOfCamera = Mathf.Lerp(currentCameraHeight, playerHeightY, Time.deltaTime * 10);

		if (playerHeightY > currentCameraHeight) {
						transform.position = new Vector3 (transform.position.x, newHeightOfCamera, transform.position.x);
				}
		else {
			if (playerHeightY < currentCameraHeight - 5.25f){
				SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);}

				}
		if (playerHeightY > OnGui2D.score) 
		{
			OnGui2D.OG2D.CheckHighScore();
			OnGui2D.score = (int)playerHeightY;
				}
				
					}
	void PlatformManager()
	{
		platCheck = player.position.y + 20;

		PlatformSpawner (platCheck + 15);
	}

	void PlatformSpawner(float floatValue)
		{
				float y = spawnPlatformsTo;
				while (y <= floatValue) {
						float x = Random.Range (-3.75f, 3.75f);
						platNumber = Random.Range (1, 5);

						Vector2 posXY = new Vector2(x,y);			

						if (platNumber == 1) {
								Instantiate (regular,posXY,Quaternion.identity);
						}
						if (platNumber == 2) {
								Instantiate (jump,posXY,Quaternion.identity);
						}
						if (platNumber == 3) {
								Instantiate (LeftRight, posXY,Quaternion.identity);
						}
						if (platNumber == 4) {
							Instantiate (UpDown,posXY,Quaternion.identity);
						}
						
			
						y += Random.Range (2.5f,3.5f);
						Debug.Log("Spawned Platform");
				}
		spawnPlatformsTo = floatValue;
		}
}
