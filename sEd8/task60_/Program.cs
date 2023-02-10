// Task 60: Form a three-dimensional array of non-repeating 
// two-digit numbers. Write a program that will print an array
//  line by line, adding the indexes of each element.
// Array size 2 x 2 x 2

// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] array = new int[2, 2, 2] { 
    { { 66, 25 }, { 34, 41 } },
    { { 27, 90 }, { 26, 55 } } };
for (int i = 0; i < 2; i++) {
    for (int j = 0; j < 2; j++) {
        for (int k = 0; k < 2; k++) {
             Console.WriteLine("{0}({1},{2},{3})", array[i, j, k], i, j, k); } } }