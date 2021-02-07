using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Beyond : MonoBehaviour
{
	public float stop;
	public GameObject beyond;
	public GameObject back;

	

	private void OnTriggerEnter(Collider other)
	{
		if (stop == 1)
		{
			beyond.SetActive(true);
			Invoke("SceneChanger", 4);
			
		}
		else if (stop == 2)
		{
			back.SetActive(true);
			Invoke("SceneChanger", 4);
		}
	}

	public void SceneChanger()
	{
		SceneManager.LoadScene(0);
		
	}
}
