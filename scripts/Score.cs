using Godot;
using System;

public class Score : Label
{
    public override void _Ready()
    {
        
    }
    public override void _Process(float delta)
    {
        Text = GetTree().Root.GetChild<main>(0).scoreAtual.ToString();
    }

}
