void FillArray(string[] array){
    for(int i = 0; i < array.Length; i++){
        Console.WriteLine("Write line ");
        array[i] = Console.ReadLine();
    }
}
void PrintArray(string[] array){
    for(int i = 0; i < array.Length; i++){
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine("\b\b  ");
}
int FindSizeOfNewArray(string[] array){
    int size = 0;
    for(int i = 0; i < array.Length; i++){
        if(array[i].Length <= 3){
            size++;
        }
    }
    return size;
}
void FillNewArrayFromOld(string[] source, string[] newArray){
    int indexSource = 0;
    int index = 0;
    while(indexSource < source.Length){
        if(source[indexSource].Length <= 3){
            newArray[index++] = source[indexSource];
        }
        indexSource++;
    }
}

int size = new Random().Next(1, 6);
string[] array = new string[size];
FillArray(array);
PrintArray(array);
int newSize = FindSizeOfNewArray(array);
string[] finalArray = new string[newSize];
FillNewArrayFromOld(array, finalArray);

