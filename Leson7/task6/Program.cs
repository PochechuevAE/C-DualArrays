// Алгоритм обхода директории 
string path = "/Users/Почечуевы/OneDrive/Desktop/Учеба/HomeWork"; //Сохраняем путь до папки
CatalogInfo(path);
DirectoryInfo dir = new DirectoryInfo(path); //Инфа о директории
System.Console.WriteLine(dir.CreationTime); //К примеру - дата создания
FileInfo [] fi = dir.GetFiles(); // Инфа о файлах

for (int i = 0; i < fi.Length; i++) //Перебираем все файлы
{
    System.Console.WriteLine(fi[i].Name);
}

void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalog = new DirectoryInfo(path);

    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        System.Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + " ");
    }

    FileInfo[] files = catalog.GetFiles();

    for (int i = 0; i < files.Length; i++)
    {
        System.Console.WriteLine($"{indent}{files[i].Name}");
    }
}

