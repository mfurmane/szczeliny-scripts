using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InspectorEntity : MonoBehaviour {
  public virtual Dictionary<string, EntityVariable> getVisualisationData() {
    return new Dictionary<string, EntityVariable>();
  }
}

