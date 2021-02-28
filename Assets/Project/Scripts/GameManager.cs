using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public int Succes;

	[SerializeField] private GameObject[] _levels;
	[SerializeField] private string _targetWord;
	[SerializeField] private int _latterWord;

	private int _currentLevel = 0;
	[SerializeField] private GameObject _panleWinLevel;
	[SerializeField] private Text _nameAnimals;
	[SerializeField] private Image _imageAnimals;

	[SerializeField] Text _levelNumber;
	
	//private void CurrentWord()
	//{
	//	for (int i = 0;  i < _latterWord; i++)
	//	{
	//		_currentWord += "*";
	//	}
	//}
	//private void ManagerCurrentWord()
	//{

	//	for(int i = 0; i <= _latterWord; i++)
	//	{
	//		_word[i] = _targetWord[i];
	//	}
	//	for(int i = 0; i<= _latterWord; i++)
	//	{
	//		if(_currentWord[i] != _targetWord[i])
	//		{
	//			_word[i] = '*';
	//		}
	//	}
	//	_currentWord = _word.ToString();
	//}
	private void Awake()
	{
		AwakeLevel();
		LoadLevel(_currentLevel);
	}
	private void AwakeLevel()
	{
		if (DataHandler.StartLevel != 0)
		{
			_currentLevel = DataHandler.StartLevel;
			_targetWord = _levels[_currentLevel].GetComponent<Level>().Word;
		}
		else
		{
			_currentLevel = default;
			_targetWord = _levels[_currentLevel].GetComponent<Level>().Word;
		}

		_latterWord = _targetWord.Length;
	}
	private void CheckingStatusGame()
	{
		
		//ManagerCurrentWord();
		if(Succes == _latterWord)
		{
			WinLevel();
		}
	}
	private void Update()
	{
		CheckingStatusGame();
	}

	private void LoadLevel(int currentLevel)
	{
		try
		{
		_levels[currentLevel].SetActive(true);
		_targetWord = _levels[_currentLevel].GetComponent<Level>().Word;
		_latterWord = _targetWord.Length;
		_levelNumber.text = (currentLevel + 1).ToString();
		}
		catch
		{
			SceneManager.LoadScene("Menu");
		}
	}

	private void NextingLevel()
	{
		_levels[_currentLevel].SetActive(false);
		_currentLevel++;
		LoadLevel(_currentLevel);
	}

	private void WinLevel()
	{
		print("Уровеньй пройден!");
		PanelWinLevel();
		Succes = default;
	}

	private void PanelWinLevel()
	{
		_panleWinLevel.SetActive(true);
		_nameAnimals.text = _levels[_currentLevel].GetComponent<Level>().Word;
		_imageAnimals.sprite = _levels[_currentLevel].GetComponent<Level>().Animal.sprite;
		NextingLevel();
	}
}
