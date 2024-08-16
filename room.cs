﻿using System;

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

	public void ShowRoom()
	{
		if (Level == 1)
		{
			Console.WriteLine(" ------------------------------------- "); //1
            Console.WriteLine("| ._ _ _  _ _   _ _  ___  ___ ._ _ _  |"); //2
            Console.WriteLine("| | ' ' || | | | '_>/ . \/ . \| ' ' | |"); //3
            Console.WriteLine("| |_|_|_|`_. | |_|  \___/\___/|_|_|_| |"); //4
            Console.WriteLine("|        <___'                        |"); //5
            Console.WriteLine(" ------------------------------------- "); //6
            Console.WriteLine("|    |                                |"); //7
            Console.WriteLine("|    |________                        |"); //8
            Console.WriteLine("|    |________|                       |"); //9
            Console.WriteLine("|   /        /|_______________________|"); //10
            Console.WriteLine("|  /________//                        |"); //11
            Console.WriteLine("| |________|/                         |"); //12
            Console.WriteLine("| /                                   |"); //13
            Console.WriteLine("|/____________________________________|"); //14
        }

        if (Level == 2)
        {
            Console.WriteLine(" ------------------------------------- "); //1
            Console.WriteLine("| ._ _ _  _ _   _ _  ___  ___ ._ _ _  |"); //2
            Console.WriteLine("| | ' ' || | | | '_>/ . \/ . \| ' ' | |"); //3
            Console.WriteLine("| |_|_|_|`_. | |_|  \___/\___/|_|_|_| |"); //4
            Console.WriteLine("|        <___'                        |"); //5
            Console.WriteLine(" ------------------------------------- "); //6
            Console.WriteLine("|    |                                |"); //7
            Console.WriteLine("|    |________      ___________       |"); //8
            Console.WriteLine("|    |________|    |___________|      |"); //9
            Console.WriteLine("|   /        /|___/___________/|______|"); //10
            Console.WriteLine("|  /________//   |___________|/       |"); //11
            Console.WriteLine("| |________|/                         |"); //12
            Console.WriteLine("| /                                   |"); //13
            Console.WriteLine("|/____________________________________|"); //14
        }

        if (Level == 3)
        {
            Console.WriteLine(" ------------------------------------- "); //1
            Console.WriteLine("| ._ _ _  _ _   _ _  ___  ___ ._ _ _  |"); //2
            Console.WriteLine("| | ' ' || | | | '_>/ . \/ . \| ' ' | |"); //3
            Console.WriteLine("| |_|_|_|`_. | |_|  \___/\___/|_|_|_| |"); //4
            Console.WriteLine("|        <___'                        |"); //5
            Console.WriteLine(" ------------------------------------- "); //6
            Console.WriteLine("|    |                            __  |"); //7
            Console.WriteLine("|    |________      ___________  <  > |"); //8
            Console.WriteLine("|    |________|    |___________|  ||  |"); //9
            Console.WriteLine("|   /        /|___/___________/|__||__|"); //10
            Console.WriteLine("|  /________//   |___________|/   ||  |"); //11
            Console.WriteLine("| |________|/                         |"); //12
            Console.WriteLine("| /                                   |"); //13
            Console.WriteLine("|/____________________________________|"); //14
        }

        if (Level == 4)
        {
            Console.WriteLine(" ------------------------------------- "); //1
            Console.WriteLine("| ._ _ _  _ _   _ _  ___  ___ ._ _ _  |"); //2
            Console.WriteLine("| | ' ' || | | | '_>/ . \/ . \| ' ' | |"); //3
            Console.WriteLine("| |_|_|_|`_. | |_|  \___/\___/|_|_|_| |"); //4
            Console.WriteLine("|        <___'                        |"); //5
            Console.WriteLine(" ------------------------------------- "); //6
            Console.WriteLine("|    |                [][][][]    __  |"); //7
            Console.WriteLine("|    |________      ___________  <  > |"); //8
            Console.WriteLine("|    |________|    |___________|  ||  |"); //9
            Console.WriteLine("|   /        /|___/___________/|__||__|"); //10
            Console.WriteLine("|  /________//   |___________|/   ||  |"); //11
            Console.WriteLine("| |________|/                         |"); //12
            Console.WriteLine("| /                                   |"); //13
            Console.WriteLine("|/____________________________________|"); //14
        }

        if (Level == 5)
        {
            Console.WriteLine(" ------------------------------------- "); //1
            Console.WriteLine("| ._ _ _  _ _   _ _  ___  ___ ._ _ _  |"); //2
            Console.WriteLine("| | ' ' || | | | '_>/ . \/ . \| ' ' | |"); //3
            Console.WriteLine("| |_|_|_|`_. | |_|  \___/\___/|_|_|_| |"); //4
            Console.WriteLine("|        <___'                        |"); //5
            Console.WriteLine(" ------------------------------------- "); //6
            Console.WriteLine("|    |                [][][][]    __  |"); //7
            Console.WriteLine("|    |________      ___________  <  > |"); //8
            Console.WriteLine("|    |________|    |___________|  ||  |"); //9
            Console.WriteLine("|   /        /|___/___________/|__||__|"); //10
            Console.WriteLine("|  /________//   |___________|/   ||  |"); //11
            Console.WriteLine("| |________|/  (              )       |"); //12
            Console.WriteLine("| /           (______________)        |"); //13
            Console.WriteLine("|/____________________________________|"); //14
        }


    }


}

/*
<1. 초기>
 -------------------------------------                                 
| ._ _ _  _ _   _ _  ___  ___ ._ _ _  |
| | ' ' || | | | '_>/ . \/ . \| ' ' | |
| |_|_|_|`_. | |_|  \___/\___/|_|_|_| |
|        <___'                        |
|-------------------------------------|
|    |                                |
|    |________                        |
|    |________|                       |
|   /        /|_______________________|
|  /________//                        |
| |________|/                         |
| /                                   |
|/____________________________________|

<2. 소파 추가>
 -------------------------------------                                 
| ._ _ _  _ _   _ _  ___  ___ ._ _ _  |
| | ' ' || | | | '_>/ . \/ . \| ' ' | |
| |_|_|_|`_. | |_|  \___/\___/|_|_|_| |
|        <___'                        |
|-------------------------------------|
|    |                                |
|    |________      ___________       |
|    |________|    |___________|      |
|   /        /|___/___________/|______|
|  /________//   |___________|/       |
| |________|/                         |
| /                                   |
|/____________________________________|

<3. 스탠드 추가>
 -------------------------------------                                 
| ._ _ _  _ _   _ _  ___  ___ ._ _ _  |
| | ' ' || | | | '_>/ . \/ . \| ' ' | |
| |_|_|_|`_. | |_|  \___/\___/|_|_|_| |
|        <___'                        |
|-------------------------------------|
|    |                            __  |
|    |________      ___________  <  > |
|    |________|    |___________|  ||  |
|   /        /|___/___________/|__||__|
|  /________//   |___________|/   ||  |
| |________|/                         |
| /                                   |
|/____________________________________|

<4. 액자 추가>
 -------------------------------------                                 
| ._ _ _  _ _   _ _  ___  ___ ._ _ _  |
| | ' ' || | | | '_>/ . \/ . \| ' ' | |
| |_|_|_|`_. | |_|  \___/\___/|_|_|_| |
|        <___'                        |
|-------------------------------------|
|    |                [][][][]    __  |
|    |________      ___________  <  > |
|    |________|    |___________|  ||  |
|   /        /|___/___________/|__||__|
|  /________//   |___________|/   ||  |
| |________|/                         |
| /                                   |
|/____________________________________|

<5. 러그 추가>
 -------------------------------------                                 
| ._ _ _  _ _   _ _  ___  ___ ._ _ _  |
| | ' ' || | | | '_>/ . \/ . \| ' ' | |
| |_|_|_|`_. | |_|  \___/\___/|_|_|_| |
|        <___'                        |
|-------------------------------------|
|    |                [][][][]    __  |
|    |________      ___________  <  > |
|    |________|    |___________|  ||  |
|   /        /|___/___________/|__||__|
|  /________//   |___________|/   ||  |
| |________|/  (              )       |
| /           (______________)        |
|/____________________________________|

 */