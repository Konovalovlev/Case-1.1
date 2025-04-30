using System;
using System.Collections.Generic;
using System.IO;

public class Reader
{
    // Статические переменные для хранения марки стали А, В и С
    Result result = new Result();
    public static double _mark_A;
    public static double _mark_B;
    public static double _mark_C;
    public string _wareHousePath = @"Plan.txt";
    string Text;
    public void Read()
    {
        if (File.Exists(_wareHousePath) && Result._proverka == true)
        {
            Text = Result._plan;
            StreamWriter streamWriter = new StreamWriter(_wareHousePath, true);
            streamWriter.WriteLine(Text);
            streamWriter.Close();
            Result._proverka = false;
        }
    }
}