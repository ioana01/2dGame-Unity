using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public float slowness = 10f;
	public static int livesNumber;
	public GameObject heart1, heart2, heart3, gameOver, back;

	void Start()
    {
		livesNumber = 3;

		heart1.gameObject.SetActive(true);
		heart2.gameObject.SetActive(true);
		heart3.gameObject.SetActive(true);
		gameOver.gameObject.SetActive(false);
		back.gameObject.SetActive(false);
	}

	public void DeleteHeart()
    {
		switch(livesNumber)
        {
			case 2:
			{
				Destroy(heart3);
				break;
			}
			case 1:
			{
				Destroy(heart2);
				break;
			}
			case 0:
			{ 
				Destroy(heart1);
				gameOver.gameObject.SetActive(true);
				back.gameObject.SetActive(true);
					Time.timeScale = 0;
				break;	
			}
		}
    }

	

}
