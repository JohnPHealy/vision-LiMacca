using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Cinemachine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;

    public Transform respawnPoint;
    public GameObject playerPrefab;

    public CinemachineVirtualCameraBase cam;

    private void Awake()
    {
        instance = this;
    }

    public void Respawn()
    {
        SceneManager.LoadScene("Lvel");
    }
}
