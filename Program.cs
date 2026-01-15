using System.Data.SqlTypes;
namespace ball_tournament
{
internal class Program
{
    static double Probability_founder(int[]squad_1,int[] squad_2) {
        double squad_chance=0;
        int squad_1_power=0;
        int squad_2_power=0;
        for(int i=0; i<squad_1.Lenght; i++)
        {
            squad_1_power += squad_1[i];
            squad_2_power += squad_2[i];
        }
        squad_chance= squad_1_power/(squad_1_power+squad_2_power)*100;
        return squad_chance
    }
    static void Squad_power(int[] a)
    {
​
        for (int i = 0; i < a.Length; i++)
        {
​
            a[i] = rand_roll.Next(30,100);
​
        }
​
​
    }
    static int[] Goal_morale(int[] squad_main)
    {
        for (int j = 0; j < squad_main.Length; j++)
        {
            if (squad_main[j] > 0)
            {
                squad_main[j] += 5;

FastCMP Trace Pixel
}
