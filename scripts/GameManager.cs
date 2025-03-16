using Godot;
using System;

public partial class GameManager : Node2D
{

    float currentDificulty = 1.0f;
    float baseHP = 100;
    float points = 0;

    public float getCurrentDificulty(){
        return currentDificulty;
    }
    public void setCurrentDificutly(float diff){
        currentDificulty = diff;
    }
    public float getPoints(){
        return points;
    }
    public void setPoints(int x){
        points += x;
    }
    public float getBaseHP(){
        return baseHP * currentDificulty;
    }

}
