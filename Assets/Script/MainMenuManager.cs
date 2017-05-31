using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour {
    public GameObject Panel;

    public void Settings()
	{
		
	}

	public void GamePlay()
	{
		SceneManager.LoadScene ("Game Scena");
	}

	public void About()
	{

        Panel.SetActive(true);
    }
}
