using System;

public class Room
{
	public int Level { get; private set; }
	public int MaxLevel { get; } = 5;

	private int[] upgCost = { 200, 200, 300, 400 };

	public Room()
	{
		Level = 1;
	}

	public bool Upgrade()
	{
		if (Level == MaxLevel)
		{
			//이미 최대레벨
			return false;
		}

		int upgCost = upgCost[Level-1];

		if (Player.Balance >= upgCost)
		{
			Player.Balance -= upgCost;
			Level++
				Console.WriteLLine("방이 업그레이드 되었습니다.");
			return true;
		}

		else
		{
			Console.WriteLLine($"잔액이 {upgcost - Player.Balance}만큼 부족합니다.")
			return false;
		}
	}


}
