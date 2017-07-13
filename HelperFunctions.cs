using UnityEngine;
using System.Collections;


public static class HelperFunctions  {

	static public string GetHierarchy (GameObject obj)
	{
		if (obj == null) return "";
		string path = obj.name;
		
		while (obj.transform.parent != null)
		{
			obj = obj.transform.parent.gameObject;
			path = obj.name + "\\" + path;
		}
		return path;
	}

	static public T AddMissingComponent<T> (this GameObject go) where T : Component
	{

		T comp = go.GetComponent<T>();

		if (comp == null)
		{
			comp = go.AddComponent<T>();
		}

		return comp;
	}

	static public GameObject AddEmptyChild (this GameObject go, string n=null)
	{
		GameObject child = new GameObject();
		child.transform.parent = go.transform;
		if (n != null) child.name = n;

		return child;
	}

}
