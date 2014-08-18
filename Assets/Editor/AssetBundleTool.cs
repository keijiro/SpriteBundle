using UnityEngine;
using UnityEditor;

class AssetBundleTool
{
    [MenuItem("Test/Build Asset Bundles")]
    static void BuildAssetBundles()
    {
        var o = AssetDatabase.LoadAssetAtPath("Assets/Prefabs/Character.prefab", typeof(GameObject));
        MakeBundle(o, "android", BuildTarget.Android);
        MakeBundle(o, "iphone", BuildTarget.iPhone);
        MakeBundle(o, "webplayer", BuildTarget.WebPlayer);
    }

    static void MakeBundle(Object asset, string filename, BuildTarget target)
    {
        BuildPipeline.BuildAssetBundle(
            asset, new Object[]{ asset },
            "Assets/StreamingAssets/" + filename + ".unity3d",
            BuildAssetBundleOptions.CollectDependencies |
            BuildAssetBundleOptions.UncompressedAssetBundle,
            target
        );
    }
}
