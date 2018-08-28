<<<<<<< Updated upstream
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class PrefabData : ScriptableObject {

=======
﻿
using UnityEngine;
[CreateAssetMenu]
public class PrefabData : ScriptableObject
{
>>>>>>> Stashed changes
    public GameObject Prefab;
    public Sprite SpriteImage;
    public Color SpriteColor;

    public void OnConfigure()
    {
        var newPrefab = Instantiate(Prefab);
        var newSprite = newPrefab.GetComponent<SpriteRenderer>();
        newSprite.sprite = SpriteImage;
        newSprite.color = SpriteColor;
    }
}
