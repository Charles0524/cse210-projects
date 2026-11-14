using System;
using System.Collections.Generic;
public class Scripture
{
private Reference _reference;
private List<Word> _words;
private Random _random;
public Reference Reference
{
get { return _reference; }
set { _reference = value; }
}
public List<Word> Words
{
get { return _words; }
set { _words = value; }
}
public Scripture(Reference reference, string text)
{
_reference = reference;
_words = new List<Word>();
_random = new Random();
string[] splitText = text.Split(' ');
foreach (string wordText in splitText)
{
_words.Add(new Word(wordText));
}
}
public void HideRandomWords(int numberToHide)
{
List<Word> visibleWords = new List<Word>();
foreach (Word word in _words)
{
if (!word.IsHidden)
{
visibleWords.Add(word);
}
}
int countToHide = Math.Min(numberToHide, visibleWords.Count);
for (int i = 0; i < countToHide; i++)
{
int index = _random.Next(visibleWords.Count);
visibleWords[index].Hide();
visibleWords.RemoveAt(index);
}
}
public string GetDisplayText()
{
string displayString = _reference.GetDisplayText() + " ";
for (int i = 0; i < _words.Count; i++)
{
displayString += _words[i].GetDisplayText();
if (i < _words.Count - 1)
{
displayString += " ";
}
}
return displayString;
}
public bool IsCompletelyHidden()
{
foreach (Word word in _words)
{
if (!word.IsHidden)
{
return false;
}
}
return true;
}
}
