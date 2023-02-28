#include "pch.h"

using namespace System;
using namespace System::IO;

int main(array<System::String ^> ^args)
{
    Console::WriteLine("Имя пользователя: {0}\n", Environment::UserName);

    for each (DriveInfo^ drive in DriveInfo::GetDrives())
    {
        Console::WriteLine("Drive {0}", drive->Name);
        Console::WriteLine("Тпи диска: {0}", drive->DriveType);
    }

    Console::WriteLine("\nСпециальные папки Windows\n");
    Array^ specialFolders = Enum::GetValues(Environment::SpecialFolder::typeid);
    for each (Environment::SpecialFolder specialFolder in specialFolders)
    {
        Console::WriteLine("{0}: {1}", specialFolder, Environment::GetFolderPath(specialFolder));
    }
    Console::ReadLine();
    return 0;
}
