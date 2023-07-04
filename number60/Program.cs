int[,,] MatrixGen(){ 
    Random rnd = new Random();
    Console.WriteLine("Введите размеры матрицы: ");
    int a = GetInt("a");
    int b = GetInt("b");
    int c = GetInt("c");
    while ( a*b*c > 90){
        Console.WriteLine("Количестов чисел в матрице должно быть меньше 90, иначе невозможно заполнить двузначными!");
        Console.WriteLine("Повторите попытку:");
        a = GetInt("a");
        b = GetInt("b");
        c = GetInt("c");    
    }
    int flag2 = 1;
    int[,,] matrix = new int[a,b,c]; 
    for (int i = 0 ; i < a ; i++){
        for (int j = 0 ; j < b ; j++){
            for (int k = 0 ; k < c ; k++){
            flag2 = 1;
            int randnumber = rnd.Next(10 , 99);
            while(Convert.ToBoolean(flag2)){
                bool flag = false ;
                for (int ii = 0 ; ii < a ; ii++){
                    for (int jj = 0 ; jj < b ; jj++){
                        for (int kk = 0 ; kk < c ; kk++){
                            if (matrix[ii,jj,kk] == randnumber){
                                flag = true;
                            }
                        }
                    }
                }
                if (flag){
                    randnumber = rnd.Next(10 , 99);    
                }else{
                    matrix[i,j,k] = randnumber;
                    flag2 = 0;    
                }
            }
            }
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
void PrintMatrix(int[,,] matr){
    Console.WriteLine("Полученная матрица: ");
    for (int i = 0 ; i < matr.GetLength(0) ; i++){
        for (int j = 0 ; j < matr.GetLength(1) ; j++){
            for (int z = 0 ; z < matr.GetLength(2) ; z++){
                Console.Write("{0}({1},{2},{3}) " ,matr[i,j,z],i,j,z);
            }
            Console.WriteLine();
        }
    }
}
PrintMatrix(MatrixGen());