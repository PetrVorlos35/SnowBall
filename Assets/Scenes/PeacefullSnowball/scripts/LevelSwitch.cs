using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class LevelSwitch : MonoBehaviour
{
    [SerializeField]
    private SceneAsset scene;

    public void SwitchScene()
    {
        SceneManager.LoadScene(scene.name); 
    }
}
