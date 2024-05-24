using Entity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterModel : MonoBehaviour
{
    private string ID;
    public CharacterEntity Entity 
    {
        get { return new CharacterEntity(ID); }
        set 
        {
            ID = value.Id;
            Entity = value;
        }
    }

    private void Awake()
    {
         Entity = new CharacterEntity(ID);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
