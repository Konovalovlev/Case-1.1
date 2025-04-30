using System;
using System.Collections.Generic;
using System.IO;

public class Reader
{
    // Статические переменные для хранения марки стали А, В и С
    Result result = new Result();
    public static double Mark_A;
    public static double Mark_B;
    public static double Mark_C;
    public string WareHousePath = @"Plan.txt";
    string Text;
    public void Read()
    {
        if (File.Exists(WareHousePath) && Result.proverka == true)
        {
            Text = Result.plan;
            StreamWriter streamWriter = new StreamWriter(WareHousePath, true);
            streamWriter.WriteLine(Text);
            streamWriter.Close();
            Result.proverka = false;
        }
    }
}