using System ;
    namespace Project 
    {
            class Program
            {
                static void Main (string[]args)
                {
                    Console.WriteLine("let us calculate your BMI");
                    Console.WriteLine("what is your wieght?");
                    int w = Convert.ToInt32(Console.ReadLine());
                    
                    Console.WriteLine("to start with calculating your hieght first please tell");

                    Console.WriteLine(" if your hieght is in meters press : 1");
                    Console.WriteLine(" if your hieght is in centimeter press : 2");

                    Console.WriteLine("if your height is in inches press : 3");

                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1 :
                        Console.WriteLine("please enter your hieght");
                        double h = Convert.ToDouble(Console.ReadLine());
                        double r = w/(h*h);
                        Console.WriteLine($"your BMI is : {r}");

                        break ;

                        case 2 :
                        Console.WriteLine("please enter your hieght");
                        double ka = Convert.ToDouble(Console.ReadLine());
                        double l = ka/(100); 
                        double f = w/(l*l);
                        Console.WriteLine($"your BMI is : {f}");

                        break ;

                        case 3 :
                        Console.WriteLine("please enter your hieght");
                        double ji = Convert.ToDouble(Console.ReadLine());
                        double t = ji/40; ;
                        double dd = w/(t*t) ;
                        Console.WriteLine($"your bmi is : {dd}");



                        break ;

                    }


                    Console.WriteLine("-->");
                    Console.WriteLine("Underweight: BMI less than 18.5");
                    Console.WriteLine("Normal Weight: BMI between 18.5 and 24.9 ");
                    Console.WriteLine("Overweight: BMI between 25 and 29.9");
                    Console.WriteLine("Obese: BMI of 30 or high is further categorized ---> ");
                    Console.WriteLine("                              Class I Obesity: BMI 30 to 34.9. ");
                    Console.WriteLine("                              Class II Obesity: BMI 35 to 39.9");
                    Console.WriteLine("                              Class III Obesity: BMI 40 or higher");

                    
                        

                    } 


                }
            }
    
