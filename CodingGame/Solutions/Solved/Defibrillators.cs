using System;
using System.Collections.Generic;


//https://www.codingame.com/ide/puzzle/defibrillators

public static class Defibrillators
{
    public static void Solve()
    {
        string LON = Console.ReadLine();
        double startLon = double.Parse(LON.Replace(',', '.'));
        string LAT = Console.ReadLine();
        double startLat = double.Parse(LAT.Replace(',', '.'));
        int N = int.Parse(Console.ReadLine());
        List<(string street, double lon, double lat)> defibrillators = new List<(string street, double lon, double lat)>(
            );

        for(int i = 0; i < N; i++)
        {
            string DEFIB = Console.ReadLine();
            var defib = DEFIB.Split(';');
            double lon = double.Parse(defib[defib.Length - 2].Replace(',', '.'));
            double lat = double.Parse(defib[defib.Length - 1].Replace(',', '.'));
            defibrillators.Add((defib[1],lon,lat));
        }

        string nearestDefib = string.Empty;
        double distance = 0;
        foreach(var defib in defibrillators)
        {
            var result = FindDistance(startLon, startLat, defib.lon, defib.lat);
            if(result <= distance)
            {
                distance = result;
                nearestDefib = defib.street;
            }
        }

        Console.WriteLine(nearestDefib);
    }

    public static double FindDistance(double lon1, double lat1, double lon2, double lat2)
    {
        var R = 6371; // Radius of the earth in km
        var x = (lon2 - lon1) * Math.Cos((lat1 + lat2) / 2);
        var y = lat2 - lat1;
        var d = Math.Sqrt(x * x + y * y) * R;
        return d;
    }
}
