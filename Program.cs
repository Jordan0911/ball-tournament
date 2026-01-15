using System.Data.SqlTypes;

namespace ball_tournament
{
    internal class Program
    {
      static int Probability_founder(int[]squad_1,int[] squad_2){
    int squad_chance=0;
    int squad_1_power=0;
    int squad_2_power=0;
    for(int i=0;i<squad_1.Lenght;i++)
    {
    squad_1_power += squad_1[i] 
    squad_2_power += squad_2[i] 
    }
    squad_chance= squad_1_power/(squad_1_power+squad_2_power);
    return squad_chance
}
        static void Squad_power(int[] a)
        {
           
            for (int i = 0; i < a.Length; i++) 
            {

            a[i] = rand_roll.Next(30,100);

            }
            
            
        }
        static int[] Goal_morale(int[] manchester_main)
        {
            for (int j = 0; j < manchester_main.Length; j++)
            {
                if (manchester_main[j] > 0)
                {
                    manchester_main[j] += 5;
                }
            }
            return manchester_main;
        }
       static Random rand_roll=new Random();
        static void Main(string[] args)
        {
            bool penalty_given = false;
            int manchester_goals = 0,manchester_chance= 0, arsenal_goals = 0,arsenal_chance=0,event_decider = 0, manchester_yellows = 0, manchester_reds = 0,penalty_decider=0;
            int[] manchester_main = new int[11];
            int[] manchester_spare = new int[5];
            int[] arsenal_main = new int[11];
            int[] arsenal_spare = new int[5];
            
              Squad_power(manchester_main);
              Squad_power(manchester_spare);
              Squad_power(arsenal_main);
              Squad_power(arsenal_spare);
            for (int i = 0; i < 90; i++) {
                event_decider = rand_roll.Next(1, 7);
                {
                    if (event_decider == 1)
                    {
manchester_chance=
                    }
                    else if (event_decider == 2)
                    {
                        while (penalty_given == false)
                        {

                            penalty_decider = rand_roll.Next(1, 7);
                            manchester_yellows++;

                            if (manchester_main[penalty_decider] >= 5)
                            {
                                manchester_main[penalty_decider] -= 5;
                                penalty_given = true;
                            }
                            else if (manchester_main[penalty_decider] <= 5 && manchester_main[penalty_decider] > 0)
                            {
                                manchester_main[penalty_decider] = 0;
                                penalty_given = true;
                            }


                        }
                        penalty_given = false;

                    }
                    else if (event_decider == 3)
                    {
                        manchester_reds++;
                        while (penalty_given == false)
                        {
                            penalty_decider = rand_roll.Next(1, 11);

                            if (manchester_main[penalty_decider] != 0)
                            {
                                manchester_main[penalty_decider] = 0;
                                penalty_given = true;
                            }
                        }




                    }
                    else if (event_decider == 4) {
                    
                    
                    }
                    
                }
            }
        }
    }
}
