using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    static public bool goalMet = false;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Projectile")
        {
            int castleNum = 0;
            if (PlayerPrefs.HasKey("Castle"))
                castleNum = Mathf.Clamp(PlayerPrefs.GetInt("Castle"), 0, 1);
            castleNum++;
            PlayerPrefs.SetInt("Castle", castleNum);
            SceneManager.LoadScene("Scene_0");
            Goal.goalMet = true;
            Material mat = GetComponent<Renderer>().material;
            Color c = mat.color; c.a = 1; mat.color = c;
        }
    }
}
