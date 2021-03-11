using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAssets : MonoBehaviour
{
    private static GameAssets instance;

    // function to receive instance variable
    public static GameAssets GetInstance()
    {
        return instance;
    }

    //function activating current class
    private void Awake()
    {
        instance = this;
    }

    // field displayed in GameAssets game object structure
    // also uses in GameHandler main game class as [GameAssets -> GetInstance() -> pipeHeadSprite]
    public Sprite pipeHeadSprite;
}
