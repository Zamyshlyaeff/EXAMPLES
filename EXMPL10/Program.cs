//  
int [] array = {1,51,22,98,33,54,22};
int n = array.Length;
int find =22;
int index =0;

while (index < n)
{
if (array[index]==find)
{
    Console.WriteLine(index);
    break;
}     //index+1;
      index++;
}

