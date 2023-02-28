#include "pch.h"

using namespace System;
using namespace System::IO;

int main(array<System::String ^> ^args)
{
    String^ path = "C:\\Users\\vvgav\\Pictures";
    array <System::String^>^ files = Directory::GetFiles(path);

    int j = 0;
    for (int i = 0; i < files->Length; i++)
    {
        FileInfo^ fileInfo = gcnew FileInfo(files->GetValue(i)->ToString());
        Console::WriteLine("Name: {0}", fileInfo->Name);
        j++;
    }
    Console::WriteLine("Колличество файлов: {0}", j);
    return 0;
}
