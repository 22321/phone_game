using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class win : MonoBehaviour
{
    private grind grind;
    private int flippedcells = 0;
    private int winamount;

	void Start ()
    {
        grind = GetComponent<grind>();
        winamount = (grind.X() * grind.Z()- grind.holl());
    }
    public void flippedcellcount()
    {
        flippedcells++;
        if (flippedcells >= winamount)
        {
            SceneManager.LoadScene("WinScene");
        }
    }
}
