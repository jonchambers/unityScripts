using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class LevelChange : MonoBehaviour
{
    public string LoadLevel;

    void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(LoadLevel);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
