using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine (EndJump());
    }

    // Update is called once per frame
   IEnumerator EndJump() {
    yield return new WaitForSeconds (2.03f);
    SceneManager.LoadScene(0);
   }

   }