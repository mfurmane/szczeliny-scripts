using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescriptionPart : MonoBehaviour {
  public string value;
//dodawanie parta w trakcie gry zapisuje czas ingame tego dodania, dzięki czemu wiemy, ile zajęło nam zbieranie kolejnych informacji
  public Condition condition;
  public AudioClip reachedSound;
}

