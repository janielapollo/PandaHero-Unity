using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {
    public GameObject [] frontMenu;
    public GameObject [] aboutMenu;

    public void EnableMenu () {
        for (int a = 0; a <= frontMenu.Length; a++) {
            frontMenu [a].SetActive (true);
            aboutMenu [a].SetActive (false);
        }

    }
    public void DisableMenu () {
        for (int b = 0; b <= frontMenu.Length; b++) {
            frontMenu [b].SetActive (false);
            aboutMenu [b].SetActive (true);
        }

    }
    public void Play () {
        SceneManager.LoadScene (1);
    }
}
