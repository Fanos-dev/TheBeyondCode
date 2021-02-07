// StartMenu
using UnityEngine;

public class StartMenu : MonoBehaviour
{
	public GameObject start;

	public GameObject AboutMenu;

	public GameObject TutorialMenu;

	public GameObject YearsMenu;
	

	private void Start()
	{
		Time.timeScale = 0f;
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.E))
		{
			Time.timeScale = 1f;
			YearsMenu.SetActive(true);
			
			start.SetActive(value: false);
		}

		if (Input.GetKeyDown(KeyCode.Escape))
		{
			Application.Quit();
		}
	}

	public void About()
	{
		start.SetActive(value: false);
		AboutMenu.SetActive(value: true);
	}

	public void Tutorial()
	{
		start.SetActive(value: false);
		TutorialMenu.SetActive(value: true);
	}

	public void Back()
	{
		start.SetActive(value: true);
		AboutMenu.SetActive(value: false);
	}

	public void Back1()
	{
		start.SetActive(value: true);
		TutorialMenu.SetActive(value: false);
	}
}
