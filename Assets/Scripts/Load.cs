﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load : MonoBehaviour {

	public void LoadByIndex(int SceneIndex){
		
		SceneManager.LoadScene (SceneIndex);

	}
}
