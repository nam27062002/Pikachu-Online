using UnityEditor;
using UnityEngine;

public class CreateBlocksProfileAsset
{
    [MenuItem("Assets/Create/BlocksProfile")]
    public static void CreateAsset()
    {
        BlocksProfile asset = ScriptableObject.CreateInstance<BlocksProfile>();

        AssetDatabase.CreateAsset(asset, "Assets/BlocksProfile.asset");
        AssetDatabase.SaveAssets();

        EditorUtility.FocusProjectWindow();

        Selection.activeObject = asset;
    }
}