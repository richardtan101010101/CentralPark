using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ChangeUI : MonoBehaviour
{
    
    public Text remainingsnowmens;
    public int remaning;
    public void OnTriggerEnter(Collider other)
    {   
        Debug.Log("collided");
        if (other.tag == "Snowman") 
        {
            other.gameObject.SetActive(false);
            Debug.Log("collided");
            remaning -= 1;
            Destroy(other);
        }
    }
    void Update()
    {
        if (remaning == 0)
        {
            SceneManager.LoadScene("Outro");
        }
        remainingsnowmens.text = "Remaining Snowmen:" + remaning.ToString();
    }
}
