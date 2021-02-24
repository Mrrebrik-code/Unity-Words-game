using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public int Succes;
	[SerializeField]private string _currentWord;

	[SerializeField] private GameObject[] _levels;
	[SerializeField] private string _targetWord;
	[SerializeField] private int _latterWord;

	private int _currentLevel = 0;
	
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
		//CurrentWord();
		LoadLevel(_currentLevel);
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

	}

	private void NextingLevel()
	{
		LoadLevel(_currentLevel);
	}

	private void WinLevel()
	{
		print("Уровеньй пройден!");
		Succes = default;
	}
}
