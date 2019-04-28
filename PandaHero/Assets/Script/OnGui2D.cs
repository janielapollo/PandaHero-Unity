using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OnGui2D : MonoBehaviour {

	public static OnGui2D OG2D;
	public static int score;
	int highScore;

	Text scoreText;
	//Text highText;
	// Use this for initialization
	void Start () {
		OG2D = this;
		score = 0;
		highScore = PlayerPrefs.GetInt ("Highscore:", 0);

		scoreText = GameObject.Find ("ScoreText").GetComponent<Text> ();
		//highText = GameObject.Find ("HighText").GetComponent<Text> ();
	
	}
	void Update()
	{
		scoreText.text =("Score:"+(score * 15));
		//highText.text =("Highscore:"+(score));
		}
	public void CheckHighScore()
	{
		if (score > highScore) {

			PlayerPrefs.SetInt("HighScore:",(score * 15));
				}
	}

}
