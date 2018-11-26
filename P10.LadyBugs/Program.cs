namespace P10.LadyBugs
{
    using System;
    using System.Linq;
    class Program
    {
        public static void Main()
        {
            int sizeField = int.Parse(Console.ReadLine());
            int[] bugIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] cells = new int[sizeField];

            for (int indexes = 0; indexes < bugIndexes.Length; indexes++)
            {
                if (bugIndexes[indexes] >= 0 && bugIndexes[indexes] < bugIndexes.Length)
                {
                    cells[bugIndexes[indexes]] = 1;
                }
            }

            string command = string.Empty;
            //string output = string.Empty;

            for (int i = 0; i < sizeField; i++)
            {
                command = Console.ReadLine();
                while (command != "end")
                {
                    string[] ladybugFly = command.Split().ToArray();
                    int[] ladybugIndex = new int[1];
                    string[] direction = new string[1];
                    int[] flyLength = new int[1];

                    ladybugIndex[0] = int.Parse(ladybugFly[0]);
                    direction[0] = ladybugFly[1];
                    flyLength[0] = int.Parse(ladybugFly[2]);

                    for (int k = 0; k < cells.Length; k++)
                    {

                        if (direction[0] == "right" && flyLength[0] >= 0 && flyLength[0] <= sizeField)
                        {
                            if (cells[k] == 1)
                            {
                                cells[k] = 0;
                                if (cells[k+1] == 1)
                                {
                                    if (k + 2 > cells.Length)
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        cells[k + 2] = 1;
                                    }
                                }
                                else
                                {
                                    cells[k + 1] = ladybugIndex[0];
                                }                                
                            }
                            else
                            {
                                cells[k] = ladybugIndex[0];
                            }
                                                       
                        }
                        else if (direction[0] == "left" && flyLength[0] >= 0 && flyLength[0] <= sizeField)
                        {
                            if (cells[k] == 1)
                            {
                                cells[k] = 0;
                                if (cells[k - 1] == 1)
                                {
                                    if (cells[k - 2] > cells.Length)
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        cells[k - 2] = 1;
                                    }
                                }
                                else
                                {
                                    cells[k - 1] = ladybugIndex[0];
                                }
                            }
                            else
                            {
                                cells[k] = ladybugIndex[0];
                            }                           
                        }
                    }                       
                    break;
                }
            }
            Console.WriteLine(string.Join(" ", cells));
        }
    }
}