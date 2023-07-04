int[,] MatrixGen(){ 
    Random rnd = new Random();
    Console.WriteLine("Введите размеры матрицы: ");
    int a = GetInt("количество строк ");
    int b = GetInt("количество столбцев ");
    int[,] matrix = new int[a,b]; 
    for (int i = 0 ; i < a ; i++){
        for (int j = 0 ; j < b ; j++){
            matrix[i,j] = rnd.Next(0 , 9);    
        }    
    }
    return matrix;
}
int GetInt(string message){
    Console.Write("Введите {0}: " , message);
    int a = Convert.ToInt32(Console.ReadLine());
    while( a < 1 ){
        Console.WriteLine("Размер должен быть натуральным числом: ");
        a = Convert.ToInt32(Console.ReadLine());
    }
    return a ;
}
void MatrixSort(int[,] matr){
    Console.WriteLine("Исходная матрица: ");
    PrintMatrix(matr);
    int[] tmp = new int[matr.GetLength(1)];
    for (int i = 0 ; i <matr.GetLength(0) ; i++ ){
        for (int j = 0 ; j < matr.GetLength(1) ; j++ ){
            tmp[j] = matr[i,j];
        }
        Array.Sort(tmp);
        Array.Reverse(tmp);
        for (int j = 0 ; j < matr.GetLength(1) ; j++ ){
            matr[i,j] = tmp[j];
        }
    }
    Console.WriteLine("Отсортированная матрица: ");
    PrintMatrix(matr);    
}
void PrintMatrix(int[,] matr){
    for (int i = 0 ; i < matr.GetLength(0) ; i++){
        for (int j = 0 ; j < matr.GetLength(1) ; j++){
            Console.Write(matr[i,j]+" ");
        }
        Console.WriteLine();
    }
}
MatrixSort(MatrixGen());