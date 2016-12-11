using System.Collections;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class CreateGrid : MonoBehaviour 
{
	private GameObject prefab;
	private GameObject[,] grid;
	private int xaxis, yaxis; 

	private void Start()
	{
		prefab = AssetDatabase.LoadAssetAtPath (Paths.groundPath,typeof(GameObject))as GameObject;
		if (!prefab)
		{
			Debug.LogError ("Could not load ground prefab, open the Paths script to check if the path is correct");
			return;
		}
		xaxis = 10;
		yaxis = 10;
		grid = new GameObject[xaxis, yaxis];
		createGrid ();
	}

	private void createGrid()
	{
		for (int i = 0; i < xaxis; i++)
		{
			for (int j = 0; j < yaxis; j++)
			{
				GameObject ground = Instantiate (prefab,new Vector3(i,prefab.transform.position.y,j),Quaternion.identity)as GameObject;
				grid [i, j] = ground;
			}
		}
	}
}
