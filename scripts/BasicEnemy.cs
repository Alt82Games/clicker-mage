using Godot;
using System;

public partial class BasicEnemy : Sprite2D
{
    Node2D objetivo;
    [Export] float currentHP;
    TextureProgressBar hpbar;

    public override void _Ready()
    {
        hpbar = GetNode<TextureProgressBar>("hpBar");
    }

}
