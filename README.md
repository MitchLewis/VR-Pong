# VR-Pong
Virtual reality pong game that works with Google Cardboard. Created using Unity 5.3.2.

Contained are the asset files used to create the game.

Important C# Scripts:

ball1.cs - Adds force to the ball, re-deploys ball after a score, and updates player and opponent counters.

score.cs - Displays the text with updated player and opponent scores.

player.cs - Keyboard based controls for moving the player paddle. Not needed for use with google cardboard, useful for testing.

playerHead.cs - Updated version of player.cs that uses cardboard controls instead of keyboard controls.

opponent.cs - Script that controls opponent behavior.


