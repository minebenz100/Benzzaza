class Program
{
    static void Main(string[] args)
    {
        Queue<char> fruit = new Queue<char>();
        Console.WriteLine("Input Size Fruit");
        while(true){
            char fruit_c;
            char.TryParse(Console.ReadLine(),out fruit_c);
            if(fruit_c!='S'&&fruit_c!='M'&&fruit_c!='L'){
                break;
            }
            else{
                if (fruit_c == 'S'){
                    fruit.Push('3');
                }
                else if (fruit_c == 'M'){
                    fruit.Push('2');
                }
                else if (fruit_c == 'L'){
                    fruit.Push('1');
                }
            }
            for(int i=0 ;i<fruit.GetLength(); i++){
            if(fruit.Get(i)=='1'){
                fruit.Push('2');
                fruit.Push('2');
            }
            else if(fruit.Get(i) == '2'){
                fruit.Push('3'); 
                fruit.Push('3'); 
                fruit.Push('3');
            }
        }
            Console.WriteLine("Fruit number");
            for(int i=0;i<fruit.GetLength(); i++) Console.Write(fruit.Get(i));
        }
    }
} 