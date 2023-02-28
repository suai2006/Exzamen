#include <string>
#include <iostream>
#include <sstream>
#include <filesystem>
#include <windows.h>

using namespace std;
namespace fs = std::filesystem;

int main()
{
    setlocale(LC_ALL, "Russian");
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);
    
    cout << endl << "Введите директорию" << endl;
    string folder;
    getline(cin, folder);
    
    cout << endl << "Введите минимальный размер файла" << endl;
    string fileSize;
    getline(cin, fileSize);
    int size = stoi(fileSize);

    string path(folder);
    int i = 0;
    for (auto& p : fs::recursive_directory_iterator(path))
    {
        if (p.file_size() > size) 
        {
            std::cout << p.path().stem().string() + "" + p.path().extension().string() << "  file size:" << p.file_size() << endl;
            i++;
        }
    }

    cout << endl << "Колличество файлов: " << i << endl;
    cout << endl << "Press Enter to exit" << endl;
    string input;
    getline(cin, input);
}