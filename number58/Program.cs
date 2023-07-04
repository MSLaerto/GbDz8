int[,] MatrixGen(){
    Console.Write("Введите число строк: ");
    int a = GetInt(); 
    Console.Write("Введите число столбцов: ");
    int b = GetInt();
    Random rnd = new Random();
    int[,] matrix = new int[a,b]; 
    for (int i = 0 ; i < a ; i++){
        for (int j = 0 ; j < b ; j++){
            matrix[i,j] = rnd.Next(0 , 9);    
        }    
    }
    return matrix;
}
int GetInt(){
    int a = Convert.ToInt32(Console.ReadLine());
    while( a < 1 ){
        Console.WriteLine("Размер должен быть натуральным числом: ");
        a = Convert.ToInt32(Console.ReadLine());
    }
    return a ;
}
void MatrixMultiplication(){
    Console.WriteLine("Введите размерность первой матрицы: ");
    int[,] matr =  MatrixGen();
    Console.WriteLine("Введите размерность второй матрицы: ");
    int[,] matr2 = MatrixGen();
    while(matr.GetLength(0) != matr2.GetLength(1)){
        Console.WriteLine("Операция умножения двух матриц выполнима только в том случае, если число столбцов в первом сомножителе равно числу строк во втором: ");
        Console.WriteLine("Введите размерность первой матрицы: ");
        matr =  MatrixGen();
        Console.WriteLine("Введите размерность второй матрицы: ");
        matr2 = MatrixGen();        
    }
    int[,] matrres = new int[matr2.GetLength(1),matr.GetLength(0)];
    Console.WriteLine("Исходная матрица 1: ");
    PrintMatrix(matr);
    Console.WriteLine("Исходная матрица 2: ");
    PrintMatrix(matr2);
    for (int i = 0; i < matr.GetLength(0); i++){
        for (int j = 0; j < matr2.GetLength(1); j++){
            for (int k = 0; k < matr2.GetLength(0); k++){
                matrres[i,j] += matr[i,k] * matr2[k,j];
            }
        }
    }
    Console.WriteLine("Полученная матрица: ");
    PrintMatrix(matrres);  
}
void PrintMatrix(int[,] matr){
    for (int i = 0 ; i < matr.GetLength(0) ; i++){
        for (int j = 0 ; j < matr.GetLength(1) ; j++){
            Console.Write(matr[i,j]+" ");
        }
        Console.WriteLine();
    }
}
MatrixMultiplication();