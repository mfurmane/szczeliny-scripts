using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest : EntityInfo {
  public enum Status {
    ACTIVE,
    DONE,
    FAILED
  }
  public bool isMain = false;
  public DescriptionPart activePhase;
  public Status status = Status.ACTIVE;
}

