﻿using System;
using System.Collections.Generic;
using System.Reflection;

/// <summary> Abstract Class </summary>
public abstract class Base {

  /// <summary> Name of the object </summary>
  public string name { get; set; }

  /// <summary> override ToString </summary>
  /// <returns> the object name and its type </returns>
  public override string ToString () {
    return $"{name} is a {this.GetType()}";
  }
}

interface IInteractive {
  void Interact ();
}

interface IBreakable {
  int durability { get; set; }
  void Break ();
}

interface ICollectable {
  bool isCollected { get; set; }
  void Collect ();
}

/// <summary> Class that inherits </summary>
class Door : Base, IInteractive {
  public Door (string name = "Door")
  {
    this.name = name;
  }

  /// <summary>Implement the interface</summary>
  public void Interact () {
    Console.WriteLine ("You try to open the {0}. It's locked.", name);
  }
}

class Decoration : Base, IInteractive, IBreakable {
  public bool isQuestItem;

  public int durability { get; set; }

  public Decoration ( string name = "Decoration", int durability = 1, bool isQuestItem = false )
  {
    if (durability <= 0)
    {
      throw new Exception("Durability must be greater than 0");
    }
    this.name = name;
    this.durability = durability;
    this.isQuestItem = isQuestItem;
  }
  public void Interact()
  {
    if (durability <= 0)
      {
        Console.WriteLine($"The {this.name} has been broken.");
      }
      else if (isQuestItem)
      {
        Console.WriteLine($"You look at the {this.name}. There's a key inside.");
      }
      else if (isQuestItem == false)
      {
        Console.WriteLine($"You look at the {this.name}. Not much to see here.");
      }
  }

  public void Break()
    {
      durability--;
      if (durability > 0)
      {
        Console.WriteLine($"You hit the {this.name}. It cracks.");
      }
      if (durability == 0)
      {
        Console.WriteLine($"You smash the {this.name}. What a mess.");
      }
      if (durability < 0)
      {
        Console.WriteLine($"The {this.name} is already broken.");
      }
    }
}

class Key : Base, ICollectable {
  public bool isCollected { get; set; }

  public Key (string name = "Key", bool isCollected = false) {
    this.name = name;
    this.isCollected = isCollected;
  }

  public void Collect () {
    if (isCollected) {
      Console.WriteLine ($"You have already picked up the {this.name}.");
    }
    else {
      isCollected = true;
      Console.WriteLine ($"You pick up the {this.name}.");
    }
  }
}

class RoomObjects{
  public static void IterateAction(List<Base> roomObjects, Type type){
    foreach (Base obj in roomObjects)
    {
      if (type.IsInstanceOfType(obj))
      {
        if (type == typeof(IInteractive))
          ((IInteractive)obj).Interact();
        if (type == typeof(IBreakable))
          ((IBreakable)obj).Break();
        if (type == typeof(ICollectable))
          ((ICollectable)obj).Collect();
      }
    }
  }
}
