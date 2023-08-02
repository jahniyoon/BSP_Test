using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Node
{
    private List<Node> childerenNodeList;

    public List<Node> ChildrenNodeList { get => childerenNodeList; set => ChildrenNodeList = value; }

    public bool Visted { get; set; }
    public Vector2Int BottomLeftAreaCorner { get; set; }
    public Vector2Int BottomRightAreaCorner { get; set; }
    public Vector2Int TopLeftAreaCorner { get; set; }
    public Vector2Int TopRightAreaCorner { get; set; }

    public Node Parent { get; set; }

    public int TreeLayerIndex { get; set; }

    public Node(Node parentNode)
    {
        childerenNodeList = new List<Node>();
        this.Parent = parentNode;
        if (parentNode != null)
        {
            parentNode.AddChild(this);
        }
    }

    public void AddChild(Node node)
    { 
          childerenNodeList.Add(node);    
    }

    public void RemoveChild(Node node)
    {
        childerenNodeList.Remove(node);
    }

}
