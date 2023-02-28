#include <iostream>
#include <string>
#include <sstream>
#include <filesystem>
#include <windows.h>

int main()
{
    setlocale(LC_ALL, "Russian");
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);
   
    HKL lang = GetKeyboardLayout(GetCurrentThreadId());
    std::cout << (lang == (HKL)"0X4090409") << std::endl;
    std::cout << lang.ToString() << std::endl;
    if (lang == (HKL)"4090409") 
    {
        std::cout << "Раскладка: En" << std::endl;
    }
    else {
        std::cout << "Раскладка: Ru" << std::endl;
    }
    int ret = GetSystemDefaultLangID();

    if (ret == 1049)
        std::cout << "Язык операционной системы русский" << std::endl;
    else
        std::cout << "is type os not russian interface" << std::endl;
}