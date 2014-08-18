using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour
{
    void Start()
    {
        var filename = "webplayer";

        if (Application.platform == RuntimePlatform.IPhonePlayer)
            filename = "iphone";
        else if (Application.platform == RuntimePlatform.Android)
            filename = "android";

        var bundle = AssetBundle.CreateFromFile(Application.streamingAssetsPath + "/" + filename + ".unity3d");

        foreach (Sprite s in bundle.LoadAll(typeof(Sprite))) Debug.Log("Sprite Texture: " + s.texture);

        Instantiate(bundle.mainAsset);
    }
}
