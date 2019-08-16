using UnityEditor;

public class AudioProcessing : AssetPostprocessor
{
    private void OnPreprocessAudio()
    {
        var importer = assetImporter as AudioImporter;
        var path = assetImporter.assetPath;

        importer.forceToMono = path.Contains("SE");
        importer.loadInBackground = path.Contains("BGM");
    }
}
