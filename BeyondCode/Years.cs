using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Years : MonoBehaviour
{

    public GameObject back;
    public GameObject e;
    public GameObject r;
    public GameObject[] years;
    public float stop = 1f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        if (stop > 2f)
		{
            back.SetActive(true);
		}
		else
		{
            back.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.E) && (stop <32))
        {
            stop += 1f;
        }
        if (Input.GetKeyDown(KeyCode.Q) && (stop >= 2f))
		{
            stop -= 1f;
		}


        if (stop == 1)
		{
            years[0].SetActive(true);
		}
		else
		{
            years[0].SetActive(false);
        }
        if (stop == 2)
        {
            years[1].SetActive(true);
        }
        else
        {
            years[1].SetActive(false);
        }
        if (stop == 3)
        {
            years[2].SetActive(true);
        }
        else
        {
            years[2].SetActive(false);
        }
        if (stop == 4)
        {
            years[3].SetActive(true);
        }
        else
        {
            years[3].SetActive(false);
        }
        if (stop == 5)
        {
            years[4].SetActive(true);
        }
        else
        {
            years[4].SetActive(false);
        }
        if (stop == 6)
        {
            years[5].SetActive(true);
        }
        else
        {
            years[5].SetActive(false);
        }
        if (stop == 7)
        {
            years[6].SetActive(true);
        }
        else
        {
            years[6].SetActive(false);
        }
        if (stop == 8)
        {
            years[7].SetActive(true);
        }
        else
        {
            years[7].SetActive(false);
        }
        if (stop == 9)
        {
            years[8].SetActive(true);
        }
        else
        {
            years[8].SetActive(false);
        }
        if (stop == 10)
        {
            years[9].SetActive(true);
        }
        else
        {
            years[9].SetActive(false);
        }
        if (stop == 11)
        {
            years[10].SetActive(true);
        }
        else
        {
            years[10].SetActive(false);
        }
        if (stop == 12)
        {
            years[11].SetActive(true);
        }
        else
        {
            years[11].SetActive(false);
        }
        if (stop == 13)
        {
            years[12].SetActive(true);
        }
        else
        {
            years[12].SetActive(false);
        }
        if (stop == 14)
        {
            years[13].SetActive(true);
        }
        else
        {
            years[13].SetActive(false);
        }
        if (stop == 15)
        {
            years[14].SetActive(true);
        }
        else
        {
            years[14].SetActive(false);
        }
        if (stop == 16)
        {
            years[15].SetActive(true);
        }
        else
        {
            years[15].SetActive(false);
        }
        if (stop == 17)
        {
            years[16].SetActive(true);
        }
        else
        {
            years[16].SetActive(false);
        }
        if (stop == 18)
        {
            years[17].SetActive(true);
        }
        else
        {
            years[17].SetActive(false);
        }
        if (stop == 19)
        {
            years[18].SetActive(true);
        }
        else
        {
            years[18].SetActive(false);
        }
        if (stop == 20)
        {
            years[19].SetActive(true);
        }
        else
        {
            years[19].SetActive(false);
        }
        if (stop == 21)
        {
            years[20].SetActive(true);
        }
        else
        {
            years[20].SetActive(false);
        }
        if (stop == 22)
        {
            years[21].SetActive(true);
        }
        else
        {
            years[21].SetActive(false);
        }
        if (stop == 23)
        {
            years[22].SetActive(true);
        }
        else
        {
            years[22].SetActive(false);
        }
        if (stop == 24)
        {
            years[23].SetActive(true);
        }
        else
        {
            years[23].SetActive(false);
        }
        if (stop == 25)
        {
            years[24].SetActive(true);
        }
        else
        {
            years[24].SetActive(false);
        }
        if (stop == 26)
        {
            years[25].SetActive(true);
        }
        else
        {
            years[25].SetActive(false);
        }
        if (stop == 27)
        {
            years[26].SetActive(true);
        }
        else
        {
            years[26].SetActive(false);
        }
        if (stop == 28)
        {
            years[27].SetActive(true);
        }
        else
        {
            years[27].SetActive(false);
        }
        if (stop == 29)
        {
            years[28].SetActive(true);
        }
        else
        {
            years[28].SetActive(false);
        }
        if (stop == 30)
        {
            years[29].SetActive(true);

        }
        else
        {
            years[29].SetActive(false);
        }
        if (stop == 31)
        {
            years[30].SetActive(true);

        }
        else
        {
            years[30].SetActive(false);
        }
        if (stop == 32)
        {
            e.SetActive(false);
            r.SetActive(true);
            if (Input.GetKeyDown(KeyCode.R))
			{
                SceneManager.LoadScene(1);

            }
            
            years[31].SetActive(true);

        }
        else
        {
            years[31].SetActive(false);
            e.SetActive(true);
            r.SetActive(false);
        }

    }

}
