using System;
using System.Collections;

class MainClass {
  public static void Main (string[] args) {
     
            int r =5;
            int c = 6;
            int[,] matrix = new int[r+2,c+2]; //create another layer example:
            /*array without layer: 123456
                                   123456
                                   123456
             will be if it is added one more layer:
                 array with layer: 00000000
                                   01234560
                                   01234560
                                   01234560
                                   00000000
            purpose: prevent array out of range error so that it is easier */
            printer(matrix,r,c);
            
  }

        static void printer(int[,] matt,int r,int c)
        {
         int a =0;
         int b =0;
        int f;
        int h;
         int v = (r*c)/3;
          Random rnd = new Random(123456);
          ArrayList list = new ArrayList();
          ArrayList list1 = new ArrayList();
            do{
             int i1 = rnd.Next(5);
             int j1 = rnd.Next(6);
             list.Add(i1);
             list1.Add(j1);
             f=j1+1;
             h=i1+1;
                      if(b>0 && list[b-1]==list[b] && list1[b-1]==list1[b]) 
             a--;
             else{
  
              matt[i1+1,j1+1]=9;
          
             if(f<7 && f>0) 
              {
                f-=1;
                if(matt[h,f]!=9)
                matt[h,f]=1;
                f+=1;
              }
              if(h<6 && h>0) 
              {
                h-=1;
                if(matt[h,f]!=9)
                matt[h,f]=1;
                h+=1;
              }
             
              a++;
             }
             b++;
           }while (a < v);

            for (int i = 0; i < matt.GetLength(0); i++ )  
            {
                for ( int j = 0; j < matt.GetLength(1); j++) 
                {
                // adjacent 
                if(j<7 && j>0 && matt[i,j]==9) 
                {
                j+=1; 
                if(matt[i,j]!=9&&matt[i,j]>0&&matt[i,j-1]==9)
                {
                 matt[i,j]+=1;
                }
                else if(matt[i,j]!=9&&matt[i,j]==0)
                {
                  matt[i,j]=1;
                }
                j-=1;
                }
                if(i<6 && i>0 && matt[i,j]==9) 
                {
                i+=1; 
                if(matt[i,j]!=9&&matt[i,j]>0&&matt[i-1,j]==9)
                {
                 matt[i,j]+=1;
                }
                else if(matt[i,j]!=9&&matt[i,j]==0)
                {
                  matt[i,j]=1;
                }
                i-=1;
                }
                // both adjacent and diagonal 
                if(j<7 && j>0 && matt[i,j]==9&&i<6 && i>0) 
                {
                j+=1; 
                i+=1;
                if(matt[i,j]!=9&&matt[i,j]>0&&matt[i-1,j-1]==9)
                {
                 matt[i,j]+=1;
                }
                else if(matt[i,j]!=9&&matt[i,j]==0)
                {
                  matt[i,j]=1;
                }
                j-=1;
                i-=1;
               
                j-=1;
                i-=1;
                if(matt[i,j]!=9&&matt[i,j]>0&&matt[i+1,j+1]==9)
                {
                 matt[i,j]+=1;
                }
                else if(matt[i,j]!=9&&matt[i,j]==0)
                {
                  matt[i,j]=1;
                }
                j+=1; 
                i+=1;
                
                i+=1;
                j-=1;
                if(matt[i,j]!=9&&matt[i,j]>0&&matt[i-1,j+1]==9)
                {
                  matt[i,j]+=1;
                }
                else if(matt[i,j]!=9&&matt[i,j]==0)
                {
                  matt[i,j]=1;
                }
                i-=1;
                j+=1;
                
                i-=1;
                j+=1;
                if(matt[i,j]!=9&&matt[i,j]>0&&matt[i+1,j-1]==9)
                {
                  matt[i,j]+=1;
                }
                else if(matt[i,j]!=9&&matt[i,j]==0)
                {
                  matt[i,j]=1;
                }
                i+=1;
                j-=1;
                }
             
                }
                
            }
            //create new int array with no layer that is a cut down of the first array
            int[,] matrix1 = new int[r,c];
            for (int i = 0; i < matt.GetLength(0)-2; i++ )  
            {
                for ( int j = 0; j < matt.GetLength(1)-2; j++) 
                {
                  matrix1[i,j]=matt[i+1,j+1];
                }
                
            }
            //convert the second int array to string array, convert 9 to X and other numbers to string
            string[,] matrix2 = new string[r,c];
             for (int i = 0; i < matrix2.GetLength(0); i++ )  
            {
                for ( int j = 0; j < matrix2.GetLength(1); j++) 
                {
                  if(matrix1[i,j]==9)
                  {
                   matrix2[i,j]="X";
                  }
                  else
                  {
                    int l;
                    string k;
                    l=matrix1[i,j];
                    k=l.ToString();
                    matrix2[i,j]=k;
                  }
                  Console.Write(matrix2[i,j] + " ");
                }
                 Console.WriteLine();
            }
           
           
          
        }
            
      }
