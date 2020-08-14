#if UNITY_EDITOR
using System.IO;
using System.Linq;
using UnityEngine;
using UnityEditor;

//TODO -Walter- Automatically spawn folders.
public static class AssetBundleBuilder 
{
    private static string OutputPath(in string platform)
    {
        string __projectPath = Application.dataPath.Substring(startIndex: 0, length: Application.dataPath.Length-7);
        string __outputPath = __projectPath + "/AssetBundles/" + platform;
        
        try
        {
            if(!Directory.Exists(path: __outputPath))
            {
                Debug.LogWarning(message: $"Path {__outputPath} doesn't exist, creating directory at path..");
                
                Directory.CreateDirectory(path: __outputPath);
            }
            else
            {
                //Debug.Log(message: $"Path {__outputPath} exists!");
            }
        }
        catch (IOException __exception)
        {
            Debug.LogError(__exception.Message);
        }

        return __outputPath;
    }
    
    [MenuItem(itemName: "Tools/Common-Games/Build AssetBundles/Windows")]
    private static void BuildAssetBundlesStandaloneWindows()
    {
        BuildPipeline.BuildAssetBundles(
            outputPath: OutputPath(platform: "Windows"),
            assetBundleOptions: BuildAssetBundleOptions.None, 
            targetPlatform: BuildTarget.StandaloneWindows);
        
        //BuildPipeline.BuildAssetBundles("Assets/[Source]/AssetBundles/Windows", BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows);
    }
    
    [MenuItem(itemName: "Tools/Common-Games/Build AssetBundles/Android")]
    private static void BuildAssetBundlesAndroid()
    {
        BuildPipeline.BuildAssetBundles(
            outputPath: OutputPath(platform: "Android"), 
            assetBundleOptions: BuildAssetBundleOptions.None, 
            targetPlatform: BuildTarget.Android);
        
        //BuildPipeline.BuildAssetBundles("Assets/[Source]/AssetBundles/Android", BuildAssetBundleOptions.None, BuildTarget.Android);
    }
        
    [MenuItem(itemName: "Tools/Common-Games/Build AssetBundles/WebGL")]
    private static void BuildAssetBundlesWebGL()
    {
        BuildPipeline.BuildAssetBundles(
            outputPath: OutputPath(platform: "WebGL"), 
            assetBundleOptions: BuildAssetBundleOptions.None, 
            targetPlatform: BuildTarget.WebGL);
        
        //BuildPipeline.BuildAssetBundles("Assets/[Source]/AssetBundles/WebGL", BuildAssetBundleOptions.None, BuildTarget.WebGL);
    }
    
    [MenuItem(itemName: "Tools/Common-Games/Build AssetBundles/[All Platforms]")]
    private static void BuildAssetBundlesAllPlatforms()
    {
        BuildAssetBundlesStandaloneWindows();
        BuildAssetBundlesAndroid();
        BuildAssetBundlesWebGL();
        
        Debug.Log("<color=green>Done building AssetBundles!</color>");
        CommonGames.Utilities.CGTK.CGDebug.PlayDing();
    }
}
#endif