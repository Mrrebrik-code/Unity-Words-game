using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

class LevelButton : MonoBehaviour
{
	[SerializeField] private int level;
	public void LevelStart()
	{
		DataHandler.StartLevel = level;
		SceneManager.LoadScene("Game");
	}
}
