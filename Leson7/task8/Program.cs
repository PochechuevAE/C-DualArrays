//Обход рахных структур
/* 
Допустим есть арифмитическое выражение 
((4 - 2) * (1 + 3)) / 10

                    /
         *            10
    -         +
  4   2     1   3

строим бинарное дерево, где / это 1 операция, * это 2 операция, 10 это 3 операция, - это 4 операция, + это 5 операция,
4 это 8 операция, 2 это 9 операция, 1 это 10 операция, 3 это 11 операция
итый элемент a(i) его дочерние элементы будут a(2i) и a(2i+1)
*/
string emp = String.Empty;
string [] tree = {emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3"};
//                 0    1    2    3     4    5    6    7    8    9   10   11
void InOrderTraversal(int pos = 1)
{
    if (pos < tree.Length)
    {
        int left = 2 * pos;
        int right = 2 * pos +1;
        if (left < tree.Length && !String.IsNullOrEmpty(tree[left]))
        {
            InOrderTraversal(left);
        }

        System.Console.WriteLine(tree[pos]);

        if (right < tree.Length && !String.IsNullOrEmpty(tree[right]))
        {
            InOrderTraversal(right);
        } 
    }
}

InOrderTraversal();

