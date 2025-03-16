using Godot;
using System;

public partial class HpBar : Node2D
{
    GameManager gameManager;
    TextureProgressBar hpBar;
    float maxHP;
    [Export] float currentHP;

    public override void _Ready()
    {
        hpBar = GetNode<TextureProgressBar>("body/progress");
        gameManager = GetTree().Root.GetChild(0).GetNode<GameManager>("gameManager");
        maxHP = gameManager.getBaseHP();
        hpBar.MaxValue = maxHP;
        
    }
    public override void _Process(double delta)
    {
        updateHp();
    }

    public void updateHp(){
        hpBar.Value -= 0.1f;
    }
}
