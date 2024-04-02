using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public int SceneId;

    public void OpenScene()
    {
        SceneManager.LoadScene(SceneId);
    }
}
