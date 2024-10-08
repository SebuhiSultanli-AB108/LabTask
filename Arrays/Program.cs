#region LabTask1
/*---> 4x4 ölçülü matrixin elementlərinin cəmini tapın. <---*/

//int[,] matris =
//{
//    {4,8,9,3},
//    {7,9,1,5},
//    {6,1,4,3},
//    {9,5,5,2}
//};

//int sum = 0;

//for(int i = 0; i < matris.GetLength(0); i++)
//{
//    for (int j = 0; j < matris.GetLength(1); j++)
//    {
//        sum += matris[i, j];
//    }
//}

//Console.WriteLine(sum);

#endregion
#region LabTask2
/*---> Martrixin baş diaqonalındakı elementlərin cəmi. <---*/

//int[,] matris =
//{
//    {4,8,9,3},
//    {7,9,1,5},
//    {6,1,4,3},
//    {9,5,5,2}
//};

//int sum = 0;

//for (int i = 0; i < matris.GetLength(0); i++)
//{
//    for (int j = 0; j < matris.GetLength(1); j++)
//    {
//        if (i == j) sum += matris[i, j];
//    }
//}

//Console.WriteLine(sum);

#endregion
#region LabTask3
/*---> Matrixin baş diaqonal və ondan yuxarıdakı elementlərin cəmi. <---*/

//int[,] matris =
//{
//    {4,8,9,3},
//    {7,9,1,5},
//    {6,1,4,3},
//    {9,5,5,1}
//};

//int sum = 0;

//for (int i = 0; i < matris.GetLength(0); i++)
//{
//    for (int j = 0; j < matris.GetLength(1); j++)
//    {
//        if (i <= j) sum += matris[i, j];
//    }
//}

//Console.WriteLine(sum);

#endregion
#region LabTask4
/*---> Matrixin baş diaqonalından yuxarıda olan ədədlərin cəmindən aşağıda olan ədədlərin cəminin fərqi. <---*/

//int[,] matris =
//{
//    {4,8,9,3},
//    {7,9,1,5},
//    {6,1,4,3},
//    {9,5,5,1}
//};

//int sumUp = 0;
//int sumDown = 0;

//for (int i = 0; i < matris.GetLength(0); i++)
//{
//    for (int j = 0; j < matris.GetLength(1); j++)
//    {
//        if (i < j) sumUp += matris[i, j];
//        else if (j < i) sumDown += matris[i, j];
//    }
//}

//Console.WriteLine(sumUp - sumDown);

#endregion