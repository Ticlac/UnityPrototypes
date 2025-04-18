using System;
using UnityEditor;
using UnityEngine;

public class GridManager : EditorWindow
{
    private int width;
    private int height;

    private GameObject parentGameObject;

    [MenuItem("Tools/Grid Generator")]
    public static void ShowWindow()
    {
        GetWindow<GridManager>("Grid Generator");
    }

    private void OnGUI()
    {
        GUILayout.Label("G�n�ration de Grille", EditorStyles.boldLabel);
        width = EditorGUILayout.IntField("Largeur", 1);
        height = EditorGUILayout.IntField("Hauteur", 1);

        if(GUILayout.Button("G�n�rer la grille"))
        {
            Debug.Log("Button g�n�rer la grille pressed");
            GenerateGrid();
        }

    }

    private void GenerateGrid()
    {
        if (parentGameObject != null)
            DestroyImmediate(parentGameObject);

        parentGameObject = new GameObject("GridGameObect");


        for(int x = 0; x <width; x++)
        {
            for(int y = 0; y<height; y++)
            {
                // TODO : 
                GameObject tile = new GameObject($"tile {x} {y}");
                tile.transform.SetParent(parentGameObject.transform);
                
                
                // 2. alterner sa couleur par rapport a la case pr�c�dente
                
                // LATER : 
                // 4. Ajouter un script a cette case ? 
            }
        }

    }
}
