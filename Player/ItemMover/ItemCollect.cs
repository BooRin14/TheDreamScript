using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemCollect : MonoBehaviour
{
    public static ItemCollect instance;
    public int requiredItems = 2;
    public int collectedItems = 0;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Item"))
        {
            collectedItems++;
            other.gameObject.SetActive(false);

            if (collectedItems >= requiredItems)
            {
                NextStage();
            }
        }
    }

    void NextStage()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}