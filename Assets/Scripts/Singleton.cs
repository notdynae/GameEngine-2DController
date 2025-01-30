using UnityEngine;

public class Singleton : MonoBehaviour
{
    static Singleton _instance;
    public void Start()
    {
        if (_instance) Destroy(gameObject);
        else { DontDestroyOnLoad(this); _instance = this; }
    }
}