using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bgmloop : MonoBehaviour
{
	public static Bgmloop music;
	void Awake()
	{
		if (music == null)
		{
			music = this;
			DontDestroyOnLoad(gameObject);
		}
		else
		{
			Destroy(gameObject);
		}
	}

}
