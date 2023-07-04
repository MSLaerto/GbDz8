void PrintMatrix(int[,] matr){
    for (int i = 0 ; i < matr.GetLength(0) ; i++){
        for (int j = 0 ; j < matr.GetLength(1) ; j++){
            Console.Write(matr[i,j]+" ");
        }
        Console.WriteLine();
    }
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
int[,] SpyralMatrix(int a , int b ){
    int[,] matr = new int [a,b];
    if (a == 1 && b == 1){
        matr[a,b] = 1;
        return matr; 
    }

    int up_left_cord_a=0;
    int up_left_cord_b=0;
    int up_right_cord_b=b-1;
    int down_right_cord_a=a-1;
    int down_left_cord_b=0;

    bool flag_up_left = false;
    bool flag_down_left = false;
    bool flag_down_right = false;
    
    int tmpa = 0;
    int tmpb = 0;
    int i = 1;
    while( i <= a*b){
        if (matr[tmpa,tmpb] == 0 ){
            matr[tmpa,tmpb] = i ;
        }else {
            i++;
            if (tmpb < up_right_cord_b && !flag_up_left){
                tmpb++;
            }else{
                flag_up_left = true;
                if(tmpa < down_right_cord_a && !flag_down_right){
                    tmpa++;
                }else{
                    flag_down_right = true;
                    if (tmpb > down_left_cord_b && !flag_down_left){
                        tmpb--;
                    }else{
                        flag_down_left = true;
                        if (tmpa > up_left_cord_a){
                            tmpa--;
                        }else{
                            flag_up_left = false;
                            flag_down_left = false;
                            flag_down_right = false;
                            up_left_cord_a++;
                            up_left_cord_b++;
                            up_right_cord_b--;
                            down_left_cord_b++;
                            down_right_cord_a--;
                            tmpa = up_left_cord_a;
                            tmpb = up_left_cord_b;
                            i--;
                            if( tmpa == tmpb && tmpa == a/2 && tmpb == b/2){
                                matr[tmpa,tmpb] = i;
                                return matr;
                            }    
                        }    
                    }
                }
            }  
        }    
    }
    return matr;
}
PrintMatrix(SpyralMatrix(GetInt("a"),GetInt("b")));