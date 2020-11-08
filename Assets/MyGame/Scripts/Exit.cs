using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public void ChangeScene()
    {
        EditorSceneManager.LoadScene("EndScene");
    }
}
