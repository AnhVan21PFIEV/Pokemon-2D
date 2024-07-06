using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLayer : MonoBehaviour
{
    [SerializeField] LayerMask solidobjectlayer;
    [SerializeField] LayerMask interactablelayer;
    [SerializeField] LayerMask grasslayer;
    [SerializeField] LayerMask playerlayer;
    [SerializeField] LayerMask fovlayer;


    public static GameLayer i { get; set; }

    private void Awake()
    {
        i = this;
    }
    public LayerMask SoildLayer
    { get => solidobjectlayer; }

    public LayerMask InteractableLayer

    { get => interactablelayer; } 
    public LayerMask GrassLayer
    { get => grasslayer; }

    public LayerMask PlayerLayer
    { get => playerlayer; }

    public LayerMask FovLayer
    { get => fovlayer; }


}
