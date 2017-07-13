using UnityEngine;
using System.Collections;
using System.Linq;
using UnityEngine.UI;

public static class O3UIUtils  {

	public static Transform FindChildIncludingDeactivated(this Transform t, string name)
	{
		var all = t.GetComponentsInChildren<Transform>(true);
		return all.FirstOrDefault(c => c.name == name);
	}

	public static Transform FindChildAll(this Transform t, string name)
	{
		var all = t.GetComponentsInChildren<Transform>(true);
		return all.FirstOrDefault(c => c.name == name);
	}

	public static void SetAlpha(this Image i, float alpha)
	{
		Color nc = i.color;
		nc.a = alpha;
		i.color = nc;
	}

	public static void SetAlpha(this Text t, float alpha)
	{
		Color nc = t.color;
		nc.a = alpha;
		t.color = nc;
	}

	public static void RemoveAllChildren(RectTransform rt)
	{
		int i = rt.childCount;
		while (i-- > 0) 
		{
			GameObject.DestroyImmediate(rt.GetChild(i).gameObject);
		}
	}

	public static void DeactiveAllChildren(GameObject go){
		int i = go.transform.childCount;
		while (i-- > 0) 
		{
			go.transform.GetChild(i).gameObject.SetActive(false);
		}
	}
}
