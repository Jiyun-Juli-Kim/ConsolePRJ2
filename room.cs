using System;

public class Room
{
	public int Level { get; private set; }
	public int MaxLevel { get; } = 5;


	private int[] upgCost = { 200, 200, 300, 400 };
	private int currBalance;
}
