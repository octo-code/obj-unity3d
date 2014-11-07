
using System.IO;

using UnityEngine;
using UnityEditor;

public class BuildPackage 
{
	public static string[] m_PackageInputPaths = 
	{
		"Assets/OBJ-IO"
	};
	public const string m_PackageOutputPath = "../build/obj-io.unitypackage";

	[MenuItem("Build/OBJ-IO/Build Package")]
	public static void BuildUnityPackage()
	{
		AssetDatabase.ExportPackage(m_PackageInputPaths, m_PackageOutputPath, ExportPackageOptions.Recurse);
	}
}
