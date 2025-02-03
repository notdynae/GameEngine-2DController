using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    public static GameManager Instance { get; private set; }
    public LevelManager levelManger;
    public Player player;
    
    public void Start()
    {
        levelManger = GameObject.Find("LevelManager").GetComponent<LevelManager>();
        player = GameObject.Find("Player").GetComponent<Player>();
        
        #region Singleton
        if (Instance) Destroy(gameObject);
        else { DontDestroyOnLoad(this); Instance = this; }
        #endregion
    }
}
